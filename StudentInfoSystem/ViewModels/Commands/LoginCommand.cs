using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentInfoSystem.ViewModels.Commands
{
    public class LoginCommand : ICommand
    {
        private readonly LoginVM _loginVm;
        public LoginCommand(LoginVM loginVM)
        {
            _loginVm = loginVM;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //TODO get username and pass from parameters
            this._loginVm.Login();
        }
    }
}
