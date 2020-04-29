using AttendanceControlAdminClient.Enums;
using System;
using System.Collections.Generic;
using System.Text;


namespace AttendanceControlAdminClient.Models
{
    public class SchoolClass
    {
        
        public int Id { get; set; }

        public Course Course { get; set; }

        public Subject Subject { get; set; }


        public Schedule Schedule { get; set; }

        public DayOfWeek Day { get; set; }
    }
}
