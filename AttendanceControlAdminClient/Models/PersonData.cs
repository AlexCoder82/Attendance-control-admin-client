using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceControlAdminClient.Models
{
    public abstract class PersonData
    {
        public int Id { get; set; }
        public string Dni { get; set; }
        public string FirstName { get; set; }
        public string LastName1 { get; set; }
        public string LastName2 { get; set; }
      //  public IEnumerable<Subject> Subjects { get; set; }
        public string FullName
        {
            get => LastName1 + " " + LastName2 + " " + FirstName;
        }
    }
}
