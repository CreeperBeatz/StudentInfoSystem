using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    internal class Student
    {
        public string name { get; set; }
        public string middle_name { get; set; }
        public string surname { get; set; }
        public string faculty { get; set; }
        public string specialty { get; set; }
        public string education_level { get; set; }
        public string faculty_num { get; set; }
        public int course { get; set; }
        public int stream { get; set; }
        public int group { get; set; }

        public Student(string name, string middle_name, string surname, string faculty, string specialty, string education_level, string faculty_num, int course, int stream, int group)
        {
            this.name = name;
            this.middle_name = middle_name;
            this.surname = surname;
            this.faculty = faculty;
            this.specialty = specialty;
            this.education_level = education_level;
            this.course = course;
            this.stream = stream;
            this.group = group;
            this.faculty_num = faculty_num;

        }

        public Student()
        {
            this.name = "Default";
            this.middle_name="Default";
            this.middle_name = "Default";
            this.course=0;
            this.stream = 0;
            this.group = 0;
            this.faculty_num = "0";
            this.education_level = "Default";
            this.faculty = "Default";
            this.specialty= "Default";
        }
    }
}
