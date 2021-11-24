using System;
using System.Collections.Generic;
using System.Text;

namespace Magazyn_2022
{
    public abstract class AUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool[] AccesLevel { get; set; }

        public int GetNewId()
        {
            return 0;
        }
    }
}
