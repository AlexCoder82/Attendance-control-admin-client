using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.Models;
using AttendanceControlAdminClient.Properties;
using Flurl;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceControlAdminClient.HttpServices
{
    public class TeacherHttpService
    {
        private static readonly string _baseUrl = Settings.Default.API_URL;

        /// <summary>
        ///     GET /api/teachers
        ///     Envia al servidor una petición de listado de todos los profesores
        /// </summary>
        /// <returns>
        ///     Retorna la lista de los profesores
        /// </returns>
        public static async Task<List<Teacher>> GetAll()
        {
            try
            {
                var result = await _baseUrl.WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token).AppendPathSegment("/teachers")
                   .GetJsonAsync<List<Teacher>>();

                return result;
            }

            catch (FlurlHttpException flurlHttpException)
            {
                try
                {
                    APIError error = await flurlHttpException.GetResponseJsonAsync<APIError>();

                    throw new ServerErrorException(error.Message);
                }
                catch (Exception)
                {
                    throw new ServerErrorException();
                }
            }

        }

        public static async Task<Teacher> Save(Teacher teacher)
        {
            try
            {
                var result = await _baseUrl.WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token).AppendPathSegment("/teachers")
                    .PostJsonAsync(teacher).ReceiveJson<Teacher>();

                return result;
            }

            catch (FlurlHttpException flurlHttpException)
            {
                try
                {
                    APIError error = await flurlHttpException.GetResponseJsonAsync<APIError>();

                    throw new ServerErrorException(error.Message);
                }
                catch (Exception)
                {
                    throw new ServerErrorException();
                }
            }

        }

        public static async Task<Teacher> Update(Teacher teacher)
        {
            try
            {
                var result = await _baseUrl.WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token).AppendPathSegment("/teachers")
                    .PutJsonAsync(teacher).ReceiveJson<Teacher>();

                return result;
            }

            catch (FlurlHttpException flurlHttpException)
            {
                try
                {
                    APIError error = await flurlHttpException.GetResponseJsonAsync<APIError>();

                    throw new ServerErrorException(error.Message);
                }
                catch (Exception)
                {
                    throw new ServerErrorException();
                }
            }

        }
    }
}
