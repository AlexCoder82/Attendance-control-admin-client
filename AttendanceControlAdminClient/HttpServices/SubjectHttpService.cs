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
    /// <summary>
    ///     Peticiones relacionadas con las asignaturas
    /// </summary>
    public class SubjectHttpService
    {

        private static readonly string _baseUrl = Settings.Default.API_URL;


        ///<summary>
        ///     Petición de listado de todas las asignaturas con
        ///     el profesor asociado
        /// </summary>
        /// <returns>
        ///     Retorna la lista de las asignaturas
        /// </returns>
        public static async Task<List<Subject>> GetAll()
        {

            try
            {
                List<Subject> result = await _baseUrl
                    .WithOAuthBearerToken(SessionService.Token)//Ruta protegida
                    .AppendPathSegment("/subjects")
                    .GetJsonAsync<List<Subject>>();

                return result;
            }
            catch (FlurlHttpException)
            {
                throw new ServerErrorException();
            }

        }

        /// <summary>
        ///     Peticion de la lista de asignaturas de un curso
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns>
        ///     Retorna la lista de asignaturas
        /// </returns>
        public static async Task<List<Subject>> GetByCourse(int courseId)
        {

            try
            {
                List<Subject> result = await _baseUrl
                    .WithOAuthBearerToken(SessionService.Token)//Ruta protegida
                    .AppendPathSegment("/subjects/courses/" + courseId)
                    .GetJsonAsync<List<Subject>>();

                return result;
            }

            catch (FlurlHttpException)
            {
                throw new ServerErrorException();
            }

        }

        /// <summary>
        ///     Peticion para crear una nueva asignatura 
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
                    .WithOAuthBearerToken(SessionService.Token)//Ruta protegida
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
        ///     Peticion para modificar una asignatura
        /// </summary>
        /// <param name="subject"></param>
        /// <returns>
        ///     Retorna la asignatura actualizada 
        /// </returns>
        public static async Task<Subject> Update(Subject subject)
        {

            try
            {
                Subject result = await _baseUrl
                    .WithOAuthBearerToken(SessionService.Token)//Ruta protegida
                    .AppendPathSegment("/subjects")
                    .PutJsonAsync(subject)
                    .ReceiveJson<Subject>();

                return result;
            }
            catch (FlurlHttpException flurlHttpException)
            {
                var status = flurlHttpException.Call.HttpStatus;

                //El servidor devuelve un 409 con un mensaje de error si se intenta modificar 
                //una asignatura dandole un nombre aue ya existe 
                //o un 400 si no se valida la asignatura
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
        ///     Peticion para asignar un profesor a una asignatura
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
                    .WithOAuthBearerToken(SessionService.Token)
                    .AppendPathSegment(url)
                    .PutAsync(null)
                    .ReceiveJson<Subject>();

                return result;
            }
            catch (FlurlHttpException)
            {
                throw new ServerErrorException();
            }

        }


        /// <summary>
        ///     Peticion para retirar la asignacion de profesor a una asignatura
        /// </summary>
        /// <param name="subjectId"></param>
        /// <returns></returns>
        public static async Task<bool> RemoveAssignedTeacher(int subjectId)
        {

            try
            {
                string url = "/subjects/" + subjectId + "/teachers";
                var result = await _baseUrl
                    .WithOAuthBearerToken(SessionService.Token)//Ruta protegida
                    .AppendPathSegment(url)
                    .PutAsync(null)
                    .ReceiveJson<bool>();

                return result;
            }
            catch (FlurlHttpException)
            {
                throw new ServerErrorException();
            }

        }

    }
}
