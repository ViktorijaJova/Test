using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test.Database.Models;

namespace Test.Database.Db
{
    public class InMemoryDataBase
    {
        private List<Student> Students { get; set; }
        private List<Subject> Subjects { get; set; }

        public InMemoryDataBase()
        {
            Students = new List<Student>
            {
               new Student() { FullName = "Viktorija Jovanovska", EmailAddress = "viktorijajovanovska@gmail.com", PhoneNumber = "+38970123456",StudentNumber = 1 },
               new Student() { FullName = "Katerina Jovanovska", EmailAddress = "katerinajovanovska@gmail.com", PhoneNumber = "+38970123456", StudentNumber = 2},
               new Student() { FullName = "Despina Jovanovska", EmailAddress = "depsinajovanovska@gmail.com", PhoneNumber = "+38970123456", StudentNumber =3 },
               new Student() { FullName = "Monika Jovanovska", EmailAddress = "monikajovanovska@gmail.com", PhoneNumber = "+38970123456",  StudentNumber = 4},


            };

            Subjects = new List<Subject>
            {
                new Subject()
                { Credits = 5,
               Name= "Math",
               Semester = 2

                },
                new Subject()
                { Credits = 8,
               Name= "Biology",
               Semester = 1

                },
                  new Subject()
                { Credits = 6,
               Name= "History",
               Semester = 1

                },  new Subject()
                { Credits = 3,
                Name= "English",
                Semester = 3
                },
    };
        }


            public Student GetStudentByFullName(string fullname)
            {
                return Students.FirstOrDefault(_student => _student.FullName.ToLower() == fullname.ToLower());
            }

            public List<Student> GetStudents()
            {
                return Students;
            }

        public List<Subject> GetAllSubjects()
        {
            return Subjects;
        
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        
    }
}
