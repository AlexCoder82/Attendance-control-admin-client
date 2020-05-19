using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.Models;
using AttendanceControlAdminClient.Properties;
using AttendanceControlAdminClient.Session;
using Flurl.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AttendanceControlAdminClient.HttpServices
{
    /// <summary>
    ///     Peticiones relacionadas a los turnos horarios
    /// </summary>
    public class ShiftHttpService
    {
        //URL base del servidor
        private static readonly string _baseUrl = Settings.Default.API_URL;
        //URL del controlador 
        private static readonly string _controllerUrl = "shifts";


        /// <summary>
        ///     Petición de listado de todos los turnos horarios
        /// </summary>
        /// <returns>
        /// </returns>
        public static async Task<List<Shift>> GetAll()
        {

            try
            {
                string url = _baseUrl + _controllerUrl;
                List<Shift> result = await url
                    .WithOAuthBearerToken(SessionService.Token)
                    .GetJsonAsync<List<Shift>>();
                return result;
            }
            catch (FlurlHttpException)
            {
                throw new ServerErrorException();
            }

        }
    }
}
