using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.Models;
using AttendanceControlAdminClient.Properties;
using AttendanceControlAdminClient.Session;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace AttendanceControlAdminClient.HttpServices
{
    /// <summary>
    ///     Clase que contiene todas las peticiones http 
    ///     relacionadas a los ciclos formativos
    /// </summary>
    public class CycleHttpService
    {
        //URL base del servidor
        private static readonly string _baseUrl = Settings.Default.API_URL;

        //URL del controlador 
        private static readonly string _controllerUrl = "cycles";


        /// <summary>
        ///     Envia al servidor una petición de listado de todos los ciclos con
        ///     los cursos y asignaturas asociados
        /// </summary>
        /// <returns>
        /// </returns>
        public static async Task<List<Cycle>> GetAll()
        {

            try
            {
                string url = _baseUrl + _controllerUrl;
                List<Cycle> result = await url
                    .WithOAuthBearerToken(SessionService.Token)//Ruta protegida
                    .GetJsonAsync<List<Cycle>>();

                return result;
            }
            catch (FlurlHttpException)
            {
                throw new ServerErrorException();
            }

        }

        /// <summary>
        ///     Peticion para crear un nuevo ciclo
        /// </summary>
        /// <param name="cycle"></param>
        /// <returns>
        ///     Retorna el ciclo creado 
        /// </returns>
        public static async Task<Cycle> Save(Cycle cycle)
        {

            try
            {
                string url = _baseUrl + _controllerUrl;
                Cycle result = await url
                    .WithOAuthBearerToken(SessionService.Token)//Ruta protegida
                    .PostJsonAsync(cycle)
                    .ReceiveJson<Cycle>();

                return result;
            }
            catch (FlurlHttpException flurlHttpException)
            {
                var status = flurlHttpException.Call.HttpStatus;

                //El servidor devuelve un 409 si se intenta crear 
                //un ciclo cuyo nombre ya existe o un 400 si no se valida el ciclo
                if (status == HttpStatusCode.Conflict || status == HttpStatusCode.BadRequest)
                {
                    //Mensaje de error retornado por el servidor
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

        /// <summary>
        ///     Peticion para modificar un ciclo formativo
        /// </summary>
        /// <param name="cycle"></param>
        /// <returns></returns>
        public static async Task Update(Cycle cycle)
        {
            try
            {
                string url = _baseUrl + _controllerUrl;
                var result = await url
                    .WithOAuthBearerToken(SessionService.Token)//Ruta protegida
                    .PutJsonAsync(cycle)
                    .ReceiveJson<bool>();
            }
            catch (FlurlHttpException flurlHttpException)
            {
                var status = flurlHttpException.Call.HttpStatus;

                //EL servidor retorna un 409 si el ciclo tiene un nombre que existe 
                //o un 400 si no se validan los datos del ciclo
                if (status == HttpStatusCode.Conflict || status == HttpStatusCode.BadRequest)
                {
                    //Recupera el mensaje de error retornado
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
