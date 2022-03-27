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
            ExitTestMode();
        }

        private void DeleteAllFields()
        {
            foreach(var field in personal_information.Children)
            {
                if (field is TextBox)
                {
                    ((TextBox)field).Text = String.Empty;
                }
            }

            foreach (var field in student_information.Children)
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

        private void ChangeControls(bool status)
        {
            foreach (var field in personal_information.Children)
            {
                if (field is TextBox)
                {
                    ((TextBox)field).IsEnabled = status;
                }
            }

            foreach (var field in student_information.Children)
            {
                if (field is TextBox)
                {
                    ((TextBox)field).IsEnabled = status;
                }
            }
        }

        private void EnterTestMode()
        {
            enter_test_mode_button.Visibility = Visibility.Hidden;
            exit_test_mode_button.Visibility = Visibility.Visible;
            show_user_button.Visibility = Visibility.Visible;
            clear_data_button.Visibility = Visibility.Visible;
            disable_controls_button.Visibility = Visibility.Visible;
            enable_controls_button.Visibility= Visibility.Visible;
        }

        private void ExitTestMode()
        {
            enter_test_mode_button.Visibility = Visibility.Visible;
            exit_test_mode_button.Visibility = Visibility.Hidden;
            show_user_button.Visibility = Visibility.Hidden;
            clear_data_button.Visibility = Visibility.Hidden;
            disable_controls_button.Visibility = Visibility.Hidden;
            enable_controls_button.Visibility = Visibility.Hidden;
        }

        private void enter_test_mode_button_Click(object sender, RoutedEventArgs e)
        {
            EnterTestMode();
        }

        private void exit_test_mode_button_Click(object sender, RoutedEventArgs e)
        {
            ExitTestMode();
        }

        private void show_user_button_Click(object sender, RoutedEventArgs e)
        {
            SetInfo(StudentData.TestStudents[0]); //get first user from test students
        }

        private void clear_data_button_Click(object sender, RoutedEventArgs e)
        {
            DeleteAllFields();
        }

        private void disable_controls_button_Click(object sender, RoutedEventArgs e)
        {
            ChangeControls(false);
        }

        private void enable_controls_button_Click(object sender, RoutedEventArgs e)
        {
            ChangeControls(true);
        }
    }
}
