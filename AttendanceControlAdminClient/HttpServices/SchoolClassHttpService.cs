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
    public class SchoolClassHttpService
    {
        private static readonly string _baseUrl = Settings.Default.API_URL;


        public static async Task<SchoolClass> Save(SchoolClass schoolClass)
        {
            try
            {
                var result = await _baseUrl.AppendPathSegment("/schoolclasses")
                   .PostJsonAsync(schoolClass).ReceiveJson<SchoolClass>();

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

        public static async Task<bool> SetNotCurrent(int id)
        {
            try
            {
                var result = await _baseUrl.AppendPathSegment("/schoolclasses/" +id )
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
                var result = await _baseUrl.AppendPathSegment("/schoolclasses/courses/" + courseId )
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
