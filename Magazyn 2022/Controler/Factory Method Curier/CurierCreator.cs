using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn_2022.Controler.Factory_Method_Curier
{
    public abstract class CurierCreator
    {
        protected static int CurrentFreeId = 1;
        public abstract ICurier Create(string name, string surname, string licenceNumber, int accesLvl);
    }
}
