using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazyn_2022.Controler.Factory_Method_Client;

namespace Magazyn_2022.Model.Klienci
{
    public class IndividualClient : AClient
    {
        public string Name { get; set; }  
        public string Surname { get; set; }

    }
}
