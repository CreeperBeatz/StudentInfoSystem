using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    public static class StudentData
    {
        public static List<Student> TestStudents { get { ResetStudents(); return _students; } set { } }
        private static List<Student> _students;

        private static void ResetStudents()
        {
            if (_students == null)
            {
                _students = new List<Student>();
                _students.Add(new Student("Dani", "Ivov", "Matev", "FKST", "KSI", "Highschool", "121219107", 3, 1, 29, "Active"));
            }
        }

    }
}
