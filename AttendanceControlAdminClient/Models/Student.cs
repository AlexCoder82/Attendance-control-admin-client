using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceControlAdminClient.Models
{
    public class Student:PersonData
    {
        public Course Course { get; set; }
        public int TotalAbsences { get; set; }
        public int TotalDelays { get; set; }
        public  IEnumerable<Absence> Absences { get; set; }

        public List<Subject> Subjects { get; set; }
    }
}
