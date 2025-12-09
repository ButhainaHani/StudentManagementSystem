using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    //internal class Student
    //{
    //}
    public class Student
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }
        public string Faculty { get; set; }

        public Student(string name, int id, int age, double gpa, string faculty)
        {
            Name = name;
            ID = id;
            Age = age;
            GPA = gpa;
            Faculty = faculty;
        }
    }

}
