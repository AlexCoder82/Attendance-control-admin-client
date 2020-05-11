using System.Collections.Generic;

namespace AttendanceControlAdminClient.Models
{
    /// <summary>
    ///     Objeto Asignatura
    /// </summary>
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
    }
}
