using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceControlAdminClient.Exceptions
{
    /// <summary>
    ///     Excepción lanzada cuando el el servidor devuelve un error 
    /// </summary>
    public class ServerErrorException : Exception
    {

        private static string Message = "Ocurrió un error: el servidor no responde.";

        /// <summary>
        ///     Constructor usado cuando ocurre un error esperado y se quiere 
        ///     mostrar al usuario el mensaje del error
        /// </summary>
        /// <param name="message"></param>
        public ServerErrorException(string message) : base(message)
        {
        }

        /// <summary>
        ///     Constructor usado cuando ocurre un error no esperado 
        /// </summary>
        /// <param name="message"></param>
        public ServerErrorException() : base(Message)
        {
        }

    }
}
