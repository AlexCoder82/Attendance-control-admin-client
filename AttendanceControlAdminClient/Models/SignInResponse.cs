using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceControlAdminClient.Models
{
    public class SignInResponse
    {
        public  string Token { get; set; }
        public  string Role { get; set; }

        public  string Auth
        {
            get => "Bearer " + Token;
        }
    }
}
