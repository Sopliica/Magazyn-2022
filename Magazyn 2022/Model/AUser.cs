using System;
using System.Collections.Generic;
using System.Text;

namespace Magazyn_2022
{
    public abstract class AUser
    {
        private static int CurrentFreeId { get; set; } = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int AccesLevel { get; set; }
        public int GetNewId()
        {
            CurrentFreeId++;
            return CurrentFreeId - 1;
        }
        public abstract string GetAllInfo();
    }
}
