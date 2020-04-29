using AttendanceControlAdminClient.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AttendanceControlAdminClient.Models
{
    public class Schedule
    {
        public int Id { get; set; }
       
        public string Start { get; set; }

        public string End { get; set; }
 
    }
}
