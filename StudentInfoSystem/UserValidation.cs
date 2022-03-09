using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    internal class UserValidation
    {
        public Student GetStudentDataByUser(User user)
        {
            if (user.faculty_num == null) { return null; }

            try
            {
                return (from student in StudentData.TestStudents where student.faculty_num == user.faculty_num select student).First();
            }
            catch (Exception ex) { return null; }
        }
    }
}
