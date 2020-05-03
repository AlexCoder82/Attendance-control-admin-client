using AttendanceControlAdminClient.Exceptions;
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
    public class SchoolClassHttpService
    {
        private static readonly string _baseUrl = Settings.Default.API_URL;


        public static async Task<SchoolClass> Save(SchoolClass schoolClass)
        {
            try
            {
                var result = await _baseUrl.WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token).AppendPathSegment("/schoolclasses")
                   .PostJsonAsync(schoolClass).ReceiveJson<SchoolClass>();

                return result;
            }
            catch (FlurlHttpException ex)
            {
                var status = ex.Call.HttpStatus;

                //El servidor devuelve un 409 si se intenta crear 
                //un ciclo cuyo nombre ya existe o un 400 si no se valida el ciclo
                // con un mensaje de error
                if (status == HttpStatusCode.Conflict)
                {
                    //Recupero el mensaje de error
                    string message = await ex.GetResponseStringAsync();
                    throw new ServerErrorException(message);
                }
                //Cualquier otro codigo de estado
                else
                {
                    await ServerErrorExceptionHandler.Handle(ex);

                    throw new ServerErrorException();
                }
            }

        }

        public static async Task<bool> Cancel(int id)
        {
            try
            {
                var result = await _baseUrl.WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token).AppendPathSegment("/schoolclasses/" +id )
                   .PutAsync(null).ReceiveJson<bool>();

                return result;
            }
            catch (FlurlHttpException ex)
            {
                try
                {
                    APIError error = await ex.GetResponseJsonAsync<APIError>();

                    throw new ServerErrorException(error.Message);
                }
                catch (Exception)
                {
                    throw new ServerErrorException();
                }
            }

        }

        public static async Task<List<SchoolClass>> GetByCourse(int courseId)
        {
            try
            {
                var result = await _baseUrl.WithHeader("Role", SessionService.Role)
                    .WithOAuthBearerToken(SessionService.Token).AppendPathSegment("/schoolclasses/courses/" + courseId )
                   .GetJsonAsync<List<SchoolClass>>();

                return result;
            }
            catch (FlurlHttpException ex)
            {
                try
                {
                    APIError error = await ex.GetResponseJsonAsync<APIError>();

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
