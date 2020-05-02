using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.Models;
using AttendanceControlAdminClient.Properties;
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
    public class SubjectHttpService
    {
        private static readonly string _baseUrl = Settings.Default.API_URL;

        /// <summary>
        ///     GET /api/subjects
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
                List<Subject> result = new List<Subject>();
                result = await _baseUrl.WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token).AppendPathSegment("/subjects")
                   .GetJsonAsync<List<Subject>>();

                return result;
            }

            catch (FlurlHttpException flurlHttpException)
            {
                await ServerErrorExceptionHandler.Handle(flurlHttpException);

                throw new ServerErrorException();

            }
        }

        public static async Task<List<Subject>> GetByCourse(int courseId)
        {
            try
            {
                List<Subject> result = new List<Subject>();
                result = await _baseUrl.WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token).AppendPathSegment("/subjects/courses/" + courseId)
                   .GetJsonAsync<List<Subject>>();

                return result;
            }

            catch (FlurlHttpException flurlHttpException)
            {
                await ServerErrorExceptionHandler.Handle(flurlHttpException);

                throw new ServerErrorException();
            }
        }

        /// <summary>
        ///     POST /api/subjects
        ///     Envia al servidor una nueva asignatura
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>
        ///     Retorna la asignatura creada 
        /// </returns>
        public static async Task<Subject> Save(Subject subject)
        {
            try
            {
                var result = await _baseUrl.WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token).AppendPathSegment("/subjects")
                   .PostJsonAsync(subject).ReceiveJson<Subject>();

                return result;
            }
            catch (FlurlHttpException flurlHttpException)
            {
                var status = flurlHttpException.Call.HttpStatus;

                //El servidor devuelve un 409 y un mensaje si se intenta crear 
                //una asignatura cuyo nombre ya existe
                if (status == HttpStatusCode.Conflict)
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

        /// <summary>
        ///     PUT /api/subjects
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
                var result = await _baseUrl.WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token).AppendPathSegment("/subjects")
                   .PutJsonAsync(subject).ReceiveJson<Subject>();

                return result;
            }
            catch (FlurlHttpException flurlHttpException)
            {
                var status = flurlHttpException.Call.HttpStatus;

                //El servidor devuelve un 409 y un mensaje si se intenta poner 
                //a una asignatura un nombre que ya existe
                if (status == HttpStatusCode.Conflict)
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

        /// <summary>
        ///     PUT /api/subjects
        ///     Envia al servidor el id de la asignatura y el id del nuevo profesor asignado
        /// </summary>
        /// 
        /// <returns>
        ///     Retorna la asignatura actualizada 
        /// </returns>
        public static async Task<Subject> UpdateAssignedTeacher(int subjectId, int teacherId)
        {
            try
            {
                string url = "/subjects/" + subjectId + "/teachers/" + teacherId;
                var result = await _baseUrl.WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token).AppendPathSegment(url)
                    .PutAsync(null).ReceiveJson<Subject>();

                return result;
            }
            catch (FlurlHttpException flurlHttpException)
            {
                await ServerErrorExceptionHandler.Handle(flurlHttpException);

                throw new ServerErrorException();              
            }
        }

        public static async Task<bool> RemoveTeacherAssignment(int subjectId)
        {
            try
            {
                string url = "/subjects/" + subjectId + "/teachers";
                var result = await _baseUrl.WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token).AppendPathSegment(url)
                    .PutAsync(null).ReceiveJson<bool>();

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
