using System;

namespace AttendanceControlAdminClient.Models
{
    /// <summary>
    ///     Objeto Clase
    /// </summary>
    public class SchoolClass
    {      
        public int Id { get; set; }
        public Course Course { get; set; }
        public Subject Subject { get; set; }
        public Schedule Schedule { get; set; }
        public DayOfWeek Day { get; set; }
    }
}
