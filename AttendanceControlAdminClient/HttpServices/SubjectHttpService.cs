using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.Models;
using AttendanceControlAdminClient.Properties;
using Flurl;
using Flurl.Http;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace AttendanceControlAdminClient.HttpServices
{
    public class SubjectHttpService
    {
        private static readonly string _baseUrl = Settings.Default.API_URL;

        /// GET /api/subjects
        /// <summary>
        ///     Envia al servidor una petición de listado de todas las asignaturas,
        ///     y los profesores asociados
        /// </summary>
        /// <returns>
        ///     Retorna la lista de las asignaturas
        /// </returns>
        public static async Task<List<Subject>> GetAll()
        {

            try
            {
                List<Subject> result = await _baseUrl
                    .WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token)
                    .AppendPathSegment("/subjects")
                    .GetJsonAsync<List<Subject>>();

                return result;
            }
            catch (FlurlHttpException flurlHttpException)
            {
                await ServerErrorExceptionHandler.Handle(flurlHttpException);

                throw new ServerErrorException();
            }

        }

        // GET /api/subjects/courses/{courseId}
        /// <summary>
        ///     Recibe del servidor la lista de asignturas de un curso
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns>
        ///     Retorna la lista de asignatura
        /// </returns>
        public static async Task<List<Subject>> GetByCourse(int courseId)
        {

            try
            {
                List<Subject> result = await _baseUrl
                    .WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token)
                    .AppendPathSegment("/subjects/courses/" + courseId)
                    .GetJsonAsync<List<Subject>>();

                return result;
            }

            catch (FlurlHttpException flurlHttpException)
            {
                await ServerErrorExceptionHandler.Handle(flurlHttpException);

                throw new ServerErrorException();
            }

        }

        //  POST /api/subjects
        /// <summary>
        ///     Envia al servidor una nueva asignatura para guardarla
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>
        ///     Retorna la asignatura creada 
        /// </returns>
        public static async Task<Subject> Save(Subject subject)
        {

            try
            {
                Subject result = await _baseUrl
                    .WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token)
                    .AppendPathSegment("/subjects")
                    .PostJsonAsync(subject)
                    .ReceiveJson<Subject>();

                return result;
            }
            catch (FlurlHttpException flurlHttpException)
            {
                var status = flurlHttpException.Call.HttpStatus;

                //El servidor devuelve un 409 si se intenta crear 
                //una asignatura cuyo nombre ya existe o un 400 si no se valida la asignatura
                // con un mensaje de error
                if (status == HttpStatusCode.Conflict || status == HttpStatusCode.BadRequest)
                {
                    //Recupero el mensaje de error
                    string message = await flurlHttpException.GetResponseStringAsync();
                    throw new ServerErrorException(message);
                }
                //Cualquier otro codigo de estado
                else
                {
                    await ServerErrorExceptionHandler.Handle(flurlHttpException);

                    throw new ServerErrorException();
                }

            }

        }

        //  PUT /api/subjects
        /// <summary>
        ///     Envia al servidor una asignatura modificada
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>
        ///     Retorna la asignatura actualizada 
        /// </returns>
        public static async Task<Subject> Update(Subject subject)
        {

            try
            {
                Subject result = await _baseUrl.WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token).AppendPathSegment("/subjects")
                   .PutJsonAsync(subject).ReceiveJson<Subject>();

                return result;
            }
            catch (FlurlHttpException flurlHttpException)
            {
                var status = flurlHttpException.Call.HttpStatus;

                //El servidor devuelve un 409 con un mensaje de error si se intenta modificar 
                //una asignatura cuyo nuevo nombre ya existe o un 400 si no se valida la asignatura
                if (status == HttpStatusCode.Conflict || status == HttpStatusCode.BadRequest)
                {
                    //Recupero el mensaje de error
                    string message = await flurlHttpException.GetResponseStringAsync();
                    throw new ServerErrorException(message);
                }
                //Cualquier otro codigo de estado
                else
                {
                    await ServerErrorExceptionHandler.Handle(flurlHttpException);

                    throw new ServerErrorException();
                }
            }

        }

        // PUT /api/subjects/{subjectId}/teachers/{teacherId}
        /// <summary>    
        ///     Envia al servidor el id de la asignatura y el id del nuevo profesor asignado
        /// </summary>
        /// <returns>
        ///     Retorna la asignatura actualizada 
        /// </returns>
        public static async Task<Subject> UpdateAssignedTeacher(int subjectId, int teacherId)
        {

            try
            {
                string url = "/subjects/" + subjectId + "/teachers/" + teacherId;
                Subject result = await _baseUrl
                    .WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token)
                    .AppendPathSegment(url)
                    .PutAsync(null)
                    .ReceiveJson<Subject>();

                return result;
            }
            catch (FlurlHttpException flurlHttpException)
            {
                await ServerErrorExceptionHandler.Handle(flurlHttpException);

                throw new ServerErrorException();
            }

        }

        // PUT /api/subjects/{subjectId}/teachers
        /// <summary>
        ///     
        /// </summary>
        /// <param name="subjectId"></param>
        /// <returns></returns>
        public static async Task<bool> RemoveTeacherAssignment(int subjectId)
        {

            try
            {
                string url = "/subjects/" + subjectId + "/teachers";
                var result = await _baseUrl
                    .WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token)
                    .AppendPathSegment(url)
                    .PutAsync(null)
                    .ReceiveJson<bool>();

                return result;
            }
            catch (FlurlHttpException flurlHttpException)
            {
                await ServerErrorExceptionHandler.Handle(flurlHttpException);

                throw new ServerErrorException();

            }

        }

    }
}
