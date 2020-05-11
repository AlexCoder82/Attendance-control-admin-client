using System.Collections.Generic;

namespace AttendanceControlAdminClient.Models
{
    /// <summary>
    ///     Objeto ciclo formativo
    /// </summary>
    public class Cycle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
        public Shift Shift { get; set; }
    }
}
