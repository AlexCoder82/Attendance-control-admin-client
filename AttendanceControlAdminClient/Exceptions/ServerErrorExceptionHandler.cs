using AttendanceControlAdminClient.Models;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceControlAdminClient.Exceptions
{
    public static class ServerErrorExceptionHandler
    {
        public static async Task Handle(FlurlHttpException flurlHttpException)
        {
            try
            {
                APIError error = await flurlHttpException.GetResponseJsonAsync<APIError>();
                
                
            }
            catch (Exception ex)
            {

            }
            
        }
    }
}
