using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiliotecaClassInterfaceSegregation
{
    public class UserOperator : IAddUser, IUpdateUser
    {
        public void AddUser()
        {
            Console.WriteLine("User added by the operator.");
        }

        public void UpdateUser()
        {
            Console.WriteLine("User updated by the operator.");
        }
    }

}
