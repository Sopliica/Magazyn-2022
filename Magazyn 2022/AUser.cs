using System;
using System.Collections.Generic;
using System.Text;

namespace Magazyn_2022
{
    public abstract class AUser
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int AccesLevel { get; set; }

        public abstract int GetNewId();
        public abstract string GetAllInfo();
        
    }
}
