using AttendanceControlAdminClient.Exceptions;
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
                SignInResponse signInResponse = await url.PostJsonAsync(admin)
                    .ReceiveJson<SignInResponse>();

                SessionService.Role = signInResponse.Role;
                SessionService.Token = signInResponse.Token;
                Console.WriteLine(signInResponse.Token);
                return true;
                
            }
            catch (FlurlHttpException flurlHttpException)
            {
                var status = flurlHttpException.Call.HttpStatus;

                //El servidor devuelve un 404 si los las credenciales son erróneas
                if (status == HttpStatusCode.NotFound )
                {
                    //Recupero el mensaje de error y lanzo una excepcion con el mensaje
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
