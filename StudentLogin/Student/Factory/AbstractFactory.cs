using MVVMApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMApp.Model;

namespace MVVMApp.Factory
{
    abstract class AbstractFactory
    {
        abstract public User CreateUser(string Role); 
    }

    class ConcreteFactory : AbstractFactory
    {
        public override User CreateUser(string Role)
        {
            if (Role.Equals(Model.Role.Student))
            {
                return new Student();
            }
            else if(Role.Equals(Model.Role.Teacher))
            {
                return new Teacher();
            }

            return null;
        }
    }
}
