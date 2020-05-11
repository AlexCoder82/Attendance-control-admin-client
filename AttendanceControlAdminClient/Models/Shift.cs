using System.Collections.Generic;

namespace AttendanceControlAdminClient.Models
{
    /// <summary>
    ///     Objeto turno horario
    /// </summary>
    public class Shift
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<Schedule> Schedules { get; set; }
    }

}
