using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escola.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        public ICollection<Year> Years { get; set; }
    }
}