using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.Models;
using AttendanceControlAdminClient.Properties;
using AttendanceControlAdminClient.Session;
using Flurl;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace AttendanceControlAdminClient.HttpServices
{
    /// <summary>
    ///     Peticiones relacionadas a los profesores
    /// </summary>
    public class TeacherHttpService
    {
        private static readonly string _baseUrl = Settings.Default.API_URL;

        /// <summary>
        ///     Peticion de listado de todos los profesores
        /// </summary>
        /// <returns>
        ///     Retorna la lista de los profesores
        /// </returns>
        public static async Task<List<Teacher>> GetAll()
        {
            try
            {
                var result = await _baseUrl
                    .WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token)
                    .AppendPathSegment("/teachers")
                    .GetJsonAsync<List<Teacher>>();

                return result;
            }

            catch (FlurlHttpException)
            {
                throw new ServerErrorException();
            }

        }

        /// <summary>
        ///     Peticion para crear un nuevo profesor
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        public static async Task<Teacher> Save(Teacher teacher)
        {
            try
            {
                var result = await _baseUrl
                    .WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token)//Ruta protegida
                    .AppendPathSegment("/teachers")
                    .PostJsonAsync(teacher)
                    .ReceiveJson<Teacher>();

                return result;
            }

            catch (FlurlHttpException flurlHttpException)
            {
                var status = flurlHttpException.Call.HttpStatus;

                //El servidor devuelve un 409 si se intenta crear 
                //un profesor cuyo dni ya existe o un 400 si no se validan los datos
                if (status == HttpStatusCode.Conflict || status == HttpStatusCode.BadRequest)
                {
                    //Recupero el mensaje de error
                    string message = await flurlHttpException.GetResponseStringAsync();
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
        ///     Peticion para modificar los datos de un profesor
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        public static async Task<Teacher> Update(Teacher teacher)
        {

            try
            {
                var result = await _baseUrl
                    .WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token)//Ruta protegida
                    .AppendPathSegment("/teachers")
                    .PutJsonAsync(teacher)
                    .ReceiveJson<Teacher>();

                return result;
            }

            catch (FlurlHttpException flurlHttpException)
            {
                var status = flurlHttpException.Call.HttpStatus;

                //El servidor devuelve un 409 si se intenta modificar un profesor con un nuevo
                //dni que ya existe o un 400 si no se validan los datos
                if (status == HttpStatusCode.Conflict || status == HttpStatusCode.BadRequest)
                {
                    //Recupero el mensaje de error
                    string message = await flurlHttpException.GetResponseStringAsync();
                    throw new ServerErrorException(message);
                }
                //Cualquier otro codigo de estado
                else
                {
                    throw new ServerErrorException();
                }
            }

        }

    }
}
