using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazyn_2022.Model.Curiers;

namespace Magazyn_2022.Controler.Factory_Method_Curier
{
    public class DomesticCurierCreator : CurierCreator
    {
        public override ICurier Create(string name, string surname, string licenceNumber, int accesLvl)
        {
            DomesticCurier curier = new DomesticCurier();
            
            curier.Id = CurrentFreeId;
            curier.Name = name;
            curier.Surname = surname;
            curier.LicenceNumber = licenceNumber;
            curier.AccesLvL = accesLvl;
            CurrentFreeId++;
            return curier;
        }
    }
}
