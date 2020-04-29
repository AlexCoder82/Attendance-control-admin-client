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
    public class ScheduleHttpService
    {
        private static readonly string _baseUrl = Settings.Default.API_URL;

        
        public static async Task<List<Schedule>> GetByShift(int shiftId)
        {
            try
            {
                
               var result = await _baseUrl.AppendPathSegment("/schedules/shifts/"+shiftId)
                   .GetJsonAsync<List<Schedule>>();

                return result;
            }

            catch (FlurlHttpException flurlHttpException)
            {Console.WriteLine(flurlHttpException);
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
