using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Magazyn_2022.Model.Users;
using Magazyn_2022.Controler.Factory_Method_User;
using Microsoft.IdentityModel.Tokens;
using System.Collections;
using System.Diagnostics;

namespace Magazyn_2022.Controler.Login
{
    public class LoginControler
    {
        public List<AUser> userList = new List<AUser>();


        //testowo
        UserSpecialistCreator CreatorUserSpecialists = new UserSpecialistCreator();
        public LoginControler()
        {
            userList.Add(CreatorUserSpecialists.CreateUser("Jan","Kowalski",69));
            userList.Add(CreatorUserSpecialists.CreateUser("Paweł","Kępny",0));
        }

        public void LogIn(string login, string password)
        {
            var matchingLogin = userList.FirstOrDefault(user => login == user.Login);
            if (matchingLogin == null)
            {
                Debug.WriteLine("Brak takiego loginu.");
                return;
            }

            Debug.WriteLine(password == matchingLogin.Password ? "Udalo się zalogowac xd." : "Niepoprawne haslo.");
        }
    }
}
