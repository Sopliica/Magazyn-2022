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
        public override AUser CreateUser(string Name = "", string Surname = "", int AccessLevel = 0)
        {
            UserSpecialist user = new UserSpecialist(Name, Surname, AccessLevel);
            user.Login = $"{Name[0]}{Name[1]}{Surname[0]}{Surname[1]}";
            user.Password = "P@$$w0rd";
            return user;
        }
    }
}