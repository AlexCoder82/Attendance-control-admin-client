using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.Models;
using AttendanceControlAdminClient.Properties;
using AttendanceControlAdminClient.Session;
using Flurl.Http;
using System.Net;
using System.Threading.Tasks;

namespace AttendanceControlAdminClient.HttpServices
{
    /// <summary>
    ///     Cliente http para el login de administrador
    /// </summary>
    public static class SignInHttpService
    {
        //URL base del servidor
        private static readonly string _baseUrl = Settings.Default.API_URL;

        //URL del controlador 
        private static readonly string _controllerUrl = "admins";


        /// <summary>
        ///     POST /api/admins
        ///     Envia al servidor las credenciales del administrador
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

                //El servidor retorna un objeto SignInResponse
                SignInResponse signInResponse = await url.PostJsonAsync(admin)
                    .ReceiveJson<SignInResponse>();

                //Guarda el token  en el objeto SessionService
                SessionService.Token = signInResponse.Token;

                return true;
                
            }
            catch (FlurlHttpException flurlHttpException)
            {
                //Codigo de error
                var status = flurlHttpException.Call.HttpStatus;

                //El servidor devuelve un 404 si las credenciales son erróneas
                if (status == HttpStatusCode.NotFound )
                {
                    //Recupero el mensaje de error y lanzo una excepcion 
                    //con el mensaje retornado por el servidor
                    string message = await flurlHttpException.GetResponseStringAsync();
                    throw new ServerErrorException(message);
                }
                //Cualquier otro codigo de estado
                else
                {
                    throw new ServerErrorException();
                }
            }
        }

    }
}
