using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.Models;
using AttendanceControlAdminClient.Properties;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceControlAdminClient.HttpServices
{
    public class ShiftHttpService
    {
        //URL base del servidor
        private static readonly string _baseUrl = Settings.Default.API_URL;

        //URL del controlador 
        private static readonly string _controllerUrl = "shifts";

        /// <summary>
        ///     GET /api/shifts
        ///     Envia al servidor una petición de listado de todos los turnos
        /// </summary>
        /// <returns>
        ///     Retorna la lista de los turnos o lanza una excepcion ServerErrorException
        /// </returns>
        public static async Task<List<Shift>> GetAll()
        {
            try
            {
                string url = _baseUrl + _controllerUrl;
                List<Shift> result = await url.GetJsonAsync<List<Shift>>();
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
