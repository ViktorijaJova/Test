using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Database.Models
{
    public class Student
    {
        public string FullName { get; set;}
        public string PhoneNumber { get; set;}
        public string EmailAddress { get; set;}
        public int StudentNumber { get; set;}
        public List<Subject> Subjects { get; set;}

        public Student()
        {
            StudentNumber = StudentNumber + 1;
            Subjects = new List<Subject>();
        }





    }
}
