using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMApp.Model
{
    abstract class User : Login
    {
        public string Name { get; set; }
        public abstract Role RoleName { get; }
    }

    class Student : User
    {
        public override Role RoleName
        {
            get { return Role.Student; }
        }
    }

    class Admin : User
    {
        public override Role RoleName
        {
            get { return Role.Administrator; }
        }
    }

    class Teacher : User
    {
        public override Role RoleName
        {
            get { return Role.Teacher; }
        }
    }

    enum Role
    {
        Administrator = 1,
        Teacher = 2,
        Student = 3
    }
}
