using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.Models;
using AttendanceControlAdminClient.Properties;
using AttendanceControlAdminClient.Session;
using Flurl;
using Flurl.Http;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace AttendanceControlAdminClient.HttpServices
{
    class CourseHttpService
    {
        private static readonly string _baseUrl = Settings.Default.API_URL;

        /// <summary>
        ///  Peticion para asignar una asignatura a un curso
        /// </summary>
        /// <param name="courseId">
        ///     El id del curso
        /// </param>
        /// <param name="subjectId">
        ///     El id de la asignatura
        /// </param>
        /// <returns></returns>
        public static async Task<bool> AssignSubject(int courseId, int subjectId)
        {
            try
            {
                var result = await _baseUrl
                    .WithOAuthBearerToken(SessionService.Token)//Ruta protegida
                    .AppendPathSegment("/courses/" + courseId + "/subjects/" + subjectId)
                    .PutAsync(null)
                    .ReceiveJson<bool>();

                return result;
            }
            catch (FlurlHttpException ex)
            {
                // Codigo de error
                var status = ex.Call.HttpStatus;

                //El servidor devuelve un 409 si se intenta asignar una asignatura ya asignada
                if (status == HttpStatusCode.Conflict)
                {
                    //Recupero el mensaje de error y lanzo una excepcion 
                    //con el mensaje retornado por el servidor
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
        ///     Peticion para retirar una asignatura de un curso
        /// </summary>
        /// <param name="courseId">
        ///     El id del curso
        /// </param>
        /// <param name="subjectId">
        ///     El id de la asignatura
        /// </param>
        public static async Task RemoveAssignedSubject(int courseId, int subjectId)
        {
            try
            {

                var result = await _baseUrl
                    .WithOAuthBearerToken(SessionService.Token)//Ruta protegida
                    .AppendPathSegment("/courses/" + courseId + "/subjects/" + subjectId)
                    .DeleteAsync()
                    .ReceiveJson<bool>();

            }
            catch (FlurlHttpException)
            {
                throw new ServerErrorException();
            }

        }

        /// <summary>
        ///     Peticion para listar todos los cursos
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Course>> GetAll()
        {
            try
            {
                var result = await _baseUrl
                    .WithOAuthBearerToken(SessionService.Token)//Ruta protegida
                    .AppendPathSegment("/courses")
                    .GetJsonAsync<List<Course>>();

                return result;
            }
            catch (FlurlHttpException)
            {
                throw new ServerErrorException();
            }

        }

    }
}
