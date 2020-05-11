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
    ///     Peticiones relacionadas a los alumnos
    /// </summary>
    public class StudentHttpService
    {

        private static readonly string _baseUrl = Settings.Default.API_URL;

        /// <summary>
        ///     Peticion de una pagina de alumnos filtrados por apellido
        /// </summary>
        /// <param name="lastname">
        ///     El apellido del filtro
        /// </param>
        /// <param name="page">
        ///     El numero de la pagina
        /// </param>
        /// <returns></returns>
        public static async Task<List<Student>> GetByPageAndLasttName(string lastname, int page)
        {

            try
            {
                var result = await _baseUrl
                    .WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token)//Ruta protegida
                    .AppendPathSegment("/students/" + page)
                    .SetQueryParam("lastname", lastname)
                    .GetJsonAsync<List<Student>>();

                return result;
            }

            catch (FlurlHttpException)
            {
                throw new ServerErrorException();
            }

        }

        /// <summary>
        ///     Peticion para crear un nuevo alumno
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public static async Task<Student> Save(Student student)
        {
            try
            {
                var result = await _baseUrl
                    .WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token)//Ruta protegida
                    .AppendPathSegment("/students")
                    .PostJsonAsync(student)
                    .ReceiveJson<Student>();

                return result;
            }

            catch (FlurlHttpException flurlHttpException)
            {
                var status = flurlHttpException.Call.HttpStatus;

                //El servidor devuelve un 409 si se intenta crear 
                //un alumno cuyo dni ya existe o un 400 si no se validan los datos
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
        ///     Peticion para actualizar los datos personales de un alumno
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public static async Task<Student> Update(Student student)
        {

            try
            {
                var result = await _baseUrl
                    .WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token)//Ruta protegida
                    .AppendPathSegment("/students")
                    .PutJsonAsync(student)
                    .ReceiveJson<Student>();

                return result;
            }

            catch (FlurlHttpException flurlHttpException)
            {
                var status = flurlHttpException.Call.HttpStatus;

                //El servidor devuelve un 409 si se intenta modificar 
                //un alumno con un dni que ya existe o un 400 si no se validan los datos
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
        ///     Peticion para asignar un nuevo curso a un alumno
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="courseId"></param>
        /// <returns></returns>
        public static async Task<Student> AssignCourse(int studentId, int courseId)
        {
            try
            {
                var result = await _baseUrl.WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token)
                    .AppendPathSegment("/students/" + studentId + "/courses/" + courseId)
                    .PutAsync(null)
                    .ReceiveJson<Student>();

                return result;
            }

            catch (FlurlHttpException)
            {
                throw new ServerErrorException();
            }

        }

        /// <summary>
        ///     Peticion para retirar la asignacion de curso a un alumno
        /// </summary>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public static async Task RemoveCourse(int studentId)
        {
            try
            {
                var result = await _baseUrl
                    .WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token)//Ruta protegida
                    .AppendPathSegment("/students/" + studentId + "/courses")
                    .PutAsync(null)
                    .ReceiveJson<bool>();
            }

            catch (FlurlHttpException)
            {
                throw new ServerErrorException();
            }

        }

        /// <summary>
        ///       Peticion para asignar asignaturas
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="subjectIds"></param>
        /// <returns>
        ///     Retorna el alumno con sus asignaturas actualizadas
        /// </returns>
        public static async Task<Student> AssignSubjects(int studentId, int[] subjectIds)
        {

            try
            {
                var result = await _baseUrl
                    .WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token)//Ruta protegida
                    .AppendPathSegment("/students/" + studentId + "/subjects")
                    .SetQueryParam("subjectIds", subjectIds)
                    .PutAsync(null)
                    .ReceiveJson<Student>();

                return result;
            }

            catch (FlurlHttpException)
            {
                throw new ServerErrorException();
            }

        }

    }
}
