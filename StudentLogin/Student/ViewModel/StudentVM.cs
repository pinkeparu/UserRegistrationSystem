using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMApp.Model;
using System.Windows.Input;
using System.ComponentModel;

namespace MVVMApp.ViewModel
{
    public class LoginVM //: INotifyPropertyChanged
    {
        Login objLoginForm = new Login();
        LoginCommand objLoginCommand;

        public LoginVM()
        {
            objLoginCommand = new LoginCommand(Login, IsValid);
        }

        public string txtUserName
        {
            get
            {
                return objLoginForm.UserName;
            }
            set
            {
                objLoginForm.UserName = value;
            }
        }

        public string txtPassword
        {
            get
            {
                return objLoginForm.Password;
            }
            set
            {
                objLoginForm.Password = value;
            }
        }

        public ICommand LoginCmd
        {
            get { return objLoginCommand; }
        }

        public bool IsValid()
        {
            return true;
        }

        public void Login()
        {

        }

        //public event PropertyChangedEventHandler PropertyChanged;

        //public void Refresh(string propertyName)
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}
    }

    class LoginCommand : ICommand
    {
        Action whatToExecute;
        Func<bool> whenToExecute;

        public LoginCommand(Action what, Func<bool> when)
        {
            whatToExecute = what;
            whenToExecute = when;
        }

        public bool CanExecute(object parameter)
        {
            return whenToExecute();
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            whatToExecute();
        }
    }
}
