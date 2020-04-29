using AttendanceControlAdminClient.Enums;
using System;

namespace AttendanceControlAdminClient.Models
{
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
