using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escola.Models
{
    public class Subject
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}