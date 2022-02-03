using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;
using Magazyn_2022.Controler.Factory_Method_User;
using Magazyn_2022.Model.Users;


namespace Magazyn_2022.Controler.Login
{
    public class LoginControler
    {
        public List<AUser> userList = new List<AUser>();


        //testowo
        UserSpecialistCreator CreatorUserSpecialists = new UserSpecialistCreator();
        public LoginControler()
        {
            userList.Add(CreatorUserSpecialists.CreateUser("Jan","Kowalski",10));
            userList.Add(CreatorUserSpecialists.CreateUser("Paweł","Kępny",0));
            userList.Add(CreatorUserSpecialists.CreateUser("Andrzej","Duda",11));
            userList.Add(CreatorUserSpecialists.CreateUser("Donald","Tusk",0));
            userList.Add(CreatorUserSpecialists.CreateUser("Bronisław","Komorowski",99));
            userList.Add(CreatorUserSpecialists.CreateUser("Hadolf","Aitler",71));
        }
        public AUser? LogIn(string login, string password)
        {
            if (String.IsNullOrWhiteSpace(login))
            {
                throw new ArgumentException("Zly login.", nameof(login));
            }
            if (String.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Zly password.", nameof(password));
            }
            var result = userList.FirstOrDefault(user => login == user.Login && password == user.Password);
            return result ?? null;
        }
    }
}
