using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceControlAdminClient.Models
{
    public class Course
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public List<SchoolClass> SchoolClasses { get; set; }
        public List<Subject> Subjects { get; set; }

        public Cycle Cycle { get; set; }
    }
}
