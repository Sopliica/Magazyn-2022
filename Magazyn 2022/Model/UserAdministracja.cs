﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Magazyn_2022
{
    public class UserAdministracja : AUser
    {
        public UserAdministracja(string Name, string Surname, int Lvl)
        {
            this.Id = GetNewId();
            this.Name = Name;
            this.Surname = Surname;
            this.AccesLevel = Lvl;
        }
        /*public override int GetNewId()
        {
            CurrentFreeId++;
            return CurrentFreeId - 1;
        }*/
        public override string GetAllInfo()
        {
            return this.Id + " \n" +
                    this.Name + " \n" +
                    this.Surname + " \n" +
                    this.AccesLevel + " \n" +
                    " \n--------------\n";
        }
    }
}
