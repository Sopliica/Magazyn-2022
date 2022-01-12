using Magazyn_2022.Controler.Factory_Method_User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magazyn_2022.Model.Users
{
    public abstract class AUser : IUser
    {
        private static int CurrentFreeId { get; set; } = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int AccesLevel { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int GetNewId()
        {
            CurrentFreeId++;
            return CurrentFreeId - 1;
        }

        public abstract string GetAllInfo();
    }
}
