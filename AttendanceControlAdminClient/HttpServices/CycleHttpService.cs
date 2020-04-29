using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.Models;
using AttendanceControlAdminClient.Properties;
using Flurl;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
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
        ///     GET /api/cycles
        ///     Envia al servidor una petición de listado de todos los ciclos,
        ///     los cursos y asignaturas asociados
        /// </summary>
        /// <returns>
        ///     Retorna la lista de los ciclos o lanza una excepcion ServerErrorException
        /// </returns>
        public static async Task<List<Cycle>> GetAll()
        {
            try
            {
                string url = _baseUrl + _controllerUrl;
                List<Cycle> result = await url.GetJsonAsync<List<Cycle>>();
                return result;
            }
            catch (FlurlHttpException flurlHttpException)
            {
                await ServerErrorExceptionHandler.Handle(flurlHttpException);

                throw new ServerErrorException();
            }        
        }

        /// <summary>
        ///     POST /api/cycles
        ///     Envia al servidor un nuevo ciclo formativo 
        /// </summary>
        /// <param name="cycle"></param>
        /// <returns>
        ///     Retorna el ciclo creado o lanza una excepcion ServerErrorException
        /// </returns>
        public static async Task<Cycle> Save(Cycle cycle)
        {
            try
            {
                string url = _baseUrl + _controllerUrl;
                Cycle result = await url.PostJsonAsync(cycle)
                    .ReceiveJson<Cycle>();
               
                return result;
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

        /// <summary>
        ///     PUT /api/cycles/{cycleId}
        ///     Envia al servidor el nuevo nombre de un ciclo 
        /// </summary>
        /// <param name="cycleId">
        ///     El id del ciclo a modificar
        /// </param>
        /// <param name="name">
        ///     El nuevo nombre del ciclo
        /// </param>
        /// <returns>
        ///     Retorna true o lanza una excepcion ServerErrorException
        /// </returns>
        public static async Task<bool> UpdateName(int cycleId, string name)
        {
            try
            {
                string url = _baseUrl + _controllerUrl + "/"+cycleId;
                var result = await url.PutJsonAsync(name).ReceiveJson<bool>();

                return result;
            }
            catch (FlurlHttpException flurlHttpException)
            {
                var status = flurlHttpException.Call.HttpStatus;

                //El servidor devuelve un 409 y un mensaje si se intenta dar a  
                //un ciclo un nombre que ya existe
                if (status == HttpStatusCode.Conflict)
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
