using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.Models;
using AttendanceControlAdminClient.Properties;
using AttendanceControlAdminClient.Session;
using Flurl;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceControlAdminClient.HttpServices
{
    /// <summary>
    ///     Peticiones relacionadas a las clases
    /// </summary>
    public class SchoolClassHttpService
    {

        private static readonly string _baseUrl = Settings.Default.API_URL;

        /// <summary>
        ///     Peticion para crear una nueva clase
        /// </summary>
        /// <param name="schoolClass"></param>
        /// <returns>
        ///     Retorna la clase creada
        /// </returns>
        public static async Task<SchoolClass> Save(SchoolClass schoolClass)
        {

            try
            {
                var result = await _baseUrl
                    .WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token)//Ruta protegida
                    .AppendPathSegment("/schoolclasses")
                    .PostJsonAsync(schoolClass)
                    .ReceiveJson<SchoolClass>();

                return result;
            }
            catch (FlurlHttpException ex)
            {
                var status = ex.Call.HttpStatus;

                //El servidor devuelve un 409 si se intenta crear una clase de una asignatura 
                //cuyo profesor asignado ya da otra clase a la misma hora el mismo dia
                if (status == HttpStatusCode.Conflict)
                {
                    //Recupero el mensaje de error
                    string message = await ex.GetResponseStringAsync();
                    throw new ServerErrorException(message);
                }
                //Cualquier otro codigo de estado
                else
                {
                    throw new ServerErrorException();
                }
            }

        }

        /// <summary>
        ///     Peticion para cancelar una clase
        /// </summary>
        /// <param name="schoolClassId">
        ///     El id de la clase
        /// </param>
        /// <returns></returns>
        public static async Task Cancel(int schoolClassId)
        {

            try
            {
                var result = await _baseUrl
                    .WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token)//Ruta protegida
                    .AppendPathSegment("/schoolclasses/" + schoolClassId)
                    .PutAsync(null)
                    .ReceiveJson<bool>();
            }
            catch (FlurlHttpException)
            {
                throw new ServerErrorException();
            }

        }

        /// <summary>
        ///     Peticion para listar todas las clases de un curso
        /// </summary>
        /// <param name="courseId">
        ///     El id del curso
        /// </param>
        /// <returns></returns>
        public static async Task<List<SchoolClass>> GetByCourse(int courseId)
        {
            try
            {
                var result = await _baseUrl
                    .WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token)//Ruta protegida
                    .AppendPathSegment("/schoolclasses/courses/" + courseId)
                    .GetJsonAsync<List<SchoolClass>>();

                return result;
            }
            catch (FlurlHttpException)
            {
                throw new ServerErrorException();
            }

        }

    }
}
