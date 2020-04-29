using AttendanceControlAdminClient.Models;
using AttendanceControlAdminClient.Properties;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceControlAdminClient.HttpServices
{
    public static class SignInHttpService
    {
        //URL base del servidor
        private static readonly string _baseUrl = Settings.Default.API_URL;

        //URL del controlador 
        private static readonly string _controllerUrl = "admins";


        /// <summary>
        ///     POST /api/admins
        ///     Envia al servidor los credenciales del administrador
        /// </summary>
        /// <param name="cycle"></param>
        /// <returns>
        ///     Retorna el ciclo creado o lanza una excepcion ServerErrorException
        /// </returns>
        public static async Task<bool> SignIn(Admin admin)
        {
            try
            {
                string url = _baseUrl + _controllerUrl;
                var result = await url.PostJsonAsync(admin)
                    .ReceiveJson();

                return true;
                
            }
            catch (FlurlHttpException flurlHttpException)
            {
                var status = flurlHttpException.Call.HttpStatus;

                //El servidor devuelve un 409 si se intenta crear 
                //un ciclo cuyo nombre ya existe o un 400 si no se valida el ciclo
                // con un mensaje de error
                if (status == HttpStatusCode.Conflict || status == HttpStatusCode.BadRequest)
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
    }
}
