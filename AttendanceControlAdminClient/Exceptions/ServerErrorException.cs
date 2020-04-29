using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceControlAdminClient.Exceptions
{
    public class ServerErrorException : Exception
    {
        private static string Message = "Ocurrió un error: el servidor no responde.";
        public ServerErrorException(string message) : base(message)
        {
        }

        public ServerErrorException() : base(Message)
        {
        }
    }
}
