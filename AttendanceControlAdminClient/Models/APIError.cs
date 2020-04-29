using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceControlAdminClient.Models
{
    public class APIError
    {
        public DateTime Timestamp { get; set; }
        public int StatusCode { get; set; }
        public string Error { get; set; }
        public string Message { get; set; }
        public string Path { get; set; }
    }
}
