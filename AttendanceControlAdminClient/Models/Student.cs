using System.Collections.Generic;

namespace AttendanceControlAdminClient.Models
{
    /// <summary>
    ///     Objeto Alumno
    /// </summary>
    public class Student:PersonData
    {
        public Course Course { get; set; }
        public int TotalAbsences { get; set; }
        public int TotalDelays { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
