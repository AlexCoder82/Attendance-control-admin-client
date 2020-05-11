using System.Collections.Generic;

namespace AttendanceControlAdminClient.Models
{
    /// <summary>
    ///     Objeto Curso
    /// </summary>
    public class Course
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public List<SchoolClass> SchoolClasses { get; set; }
        public List<Subject> Subjects { get; set; }
        public Cycle Cycle { get; set; }
    }
}
