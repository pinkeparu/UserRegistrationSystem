using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMApp.ViewModel
{
    class RegistrationVM : LoginVM
    {
        LoginCommand objLoginCommand;

        public RegistrationVM()
        {
            objLoginCommand = new LoginCommand(Register, IsValid);
        }

        public string Name { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        public ICommand RegisterCmd
        {
            get { return objLoginCommand; }
        }

        public bool IsValid()
        {
            return true;
        }

        public void Register()
        {

        }
    }
}
