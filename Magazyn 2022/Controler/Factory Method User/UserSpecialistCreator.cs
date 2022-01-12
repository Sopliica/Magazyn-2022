using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazyn_2022.Model.Users;

namespace Magazyn_2022.Controler.Factory_Method_User
{
    public class UserSpecialistCreator : UserCreator
    {
        public override IUser CreateUser(string Name = "", string Surname = "", int AccessLevel = 0)
        {
            return new UserSpecialist();
        }
    }
}