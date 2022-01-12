using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazyn_2022.Model.Users;

namespace Magazyn_2022.Controler.Factory_Method_User
{
    public class UserAdministracjaCreator : UserCreator
    {
        public override IUser CreateUser(string Name, string Surname, int AccesLevel)
        {
            UserAdministracja User = new UserAdministracja(Name, Surname, AccesLevel);
            return User;
        }
    }
}