using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabasedProject.Models
{
    class Consult
    {
        public string UserName { get; set; }
        public string SubjectName { get; set; }
        public DateOnly? Date { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string TeacherName { get; set; }
    }
}
