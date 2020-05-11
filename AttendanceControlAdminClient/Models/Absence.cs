using AttendanceControlAdminClient.Enums;
using System;

namespace AttendanceControlAdminClient.Models
{
    /// <summary>
    ///     Objeto ausencia
    /// </summary>
    public class Absence
    {
        public int Id { get; set; }
        public AbsenceType Type { get; set; }
        public DateTime Date { get; set; }
        public  Schedule Schedule { get; set; }
        public Subject Subject { get; set; }
        public bool IsExcused { get; set; }
    }
}
