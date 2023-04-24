using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escola.Models
{
    public class Year
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }
        // public int EnrollmentID { get; set; } BR: only enroll needs class ID
        public ICollection<Student> Students { get; set; }
    }
}