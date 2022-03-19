using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UserLogin;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DeleteAllFields()
        {
            foreach(var field in main_grid.Children)
            {
                if (field is TextBox)
                {
                    ((TextBox)field).Text = String.Empty;
                }
            }
        }

        private void SetInfo(Student student)
        {
            name_box.Text = student.name.ToString();
            middle_name_box.Text = student.middle_name.ToString();
            surname_box.Text = student.surname.ToString();

            faculty_box.Text = student.faculty.ToString();
            specialty_box.Text = student.specialty.ToString();
            oks_box.Text = student.education_level.ToString();
            status_box.Text = student.status.ToString();
            faculty_num_box.Text = student.faculty_num.ToString();
            course_box.Text = student.course.ToString();
            stream_box.Text = student.stream.ToString();
            group_box.Text = student.group.ToString();

        }

        private void DisableControls()
        {
            ChangeControls(false);
        }

        private void EnableControls()
        {
            ChangeControls(true);
        }

        private void ChangeControls(bool status)
        {
            foreach (var field in main_grid.Children)
            {
                if (field is TextBox)
                {
                    ((TextBox)field).IsEnabled = status;
                }
            }
        }
    }
}
