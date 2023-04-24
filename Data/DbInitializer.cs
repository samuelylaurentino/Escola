using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escola.Models;

namespace Escola.Data
{
    public class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {

            if (context.Students.Any())
            {
                return;  
            }

            var students = new Student[]
            {
                new Student{Name="Joao Das Neves",Email="cars@saa.gmo"},
                new Student{Name="Maria Alina",Email="rus@klisn.com"},
                new Student{Name="Pinote",Email="pinote@fns.com"},
                new Student{Name="Bruna Alves",Email="brasi@lmald.com"},
                new Student{Name="Iuri Alberto",Email="zen@alo.com"},
                new Student{Name="Peggy Olson",Email="mad@man.com"},
                new Student{Name="Lauro Paz",Email="desgi@gm.com"},
                new Student{Name="Nino Sarratore",Email="sa@rratore.com"}
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{ID=10,Title="Journalism"},
                new Course{ID=20,Title="Business"},
                new Course{ID=30,Title="Computer Science"},
                new Course{ID=40,Title="Philosophy"},
                new Course{ID=50,Title="Law"},
                new Course{ID=201,Title="Communication"},
                new Course{ID=202,Title="Literature"}
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,YearID=2020},
                new Enrollment{StudentID=1,YearID=2020},
                new Enrollment{StudentID=1,YearID=2020},
                new Enrollment{StudentID=1,YearID=2020},
                new Enrollment{StudentID=2,YearID=2020},
                new Enrollment{StudentID=2,YearID=2023},
                new Enrollment{StudentID=2,YearID=2021},
                new Enrollment{StudentID=3,YearID=2022},
                new Enrollment{StudentID=4,YearID=2019},
                new Enrollment{StudentID=4,YearID=2021},
                new Enrollment{StudentID=5,YearID=2022},
                new Enrollment{StudentID=6,YearID=2022},
                new Enrollment{StudentID=7,YearID=2021},
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();

            var subjects = new Subject[]
            {
                new Subject{Title="Writing"},
                new Subject{Title="Estoicism"},
                new Subject{Title="Philo 101"},
                new Subject{Title="Online papers"},
                new Subject{Title="Database Mgmt"},
                new Subject{Title="Marketing"},
                new Subject{Title="Digital presence"}
            };

            context.Subjects.AddRange(subjects);
            context.SaveChanges();

            var Years = new Year[]
            {
                new Year{ID=2019,Title="Class of 2019",CourseID=1050,},
                new Year{ID=2020,Title="Class of 2020",CourseID=4022,},
                new Year{ID=2021,Title="Class of 2021",CourseID=4041},
                new Year{ID=2022,Title="Class of 2022",CourseID=1045},
                new Year{ID=2023,Title="Class of 2023",CourseID=2042},
            };

            context.Years.AddRange(Years);
            context.SaveChanges();
        }
    }
}