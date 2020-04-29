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
    class AbsenceHttpService
    {
        private static readonly string _baseUrl = Settings.Default.API_URL;

        public static async Task<List<Absence>> GetByStudent(int studentId)
        {
            try
            {
                var result = await _baseUrl.AppendPathSegment("/absences/students/"+studentId)
                   .GetJsonAsync<List<Absence>>();

                return result;
            }
            catch (FlurlHttpException ex)
            {
                Console.WriteLine(ex.Message);
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

        public static async Task<bool> SetExcused(int absenceId, bool isExcused)
        {
            try
            {
                var result = await _baseUrl.AppendPathSegment("/absences/" + absenceId)
                   .PutJsonAsync(isExcused).ReceiveJson<bool>();

                return result;
            }
            catch (FlurlHttpException ex)
            {
                Console.WriteLine(ex.Message);
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
