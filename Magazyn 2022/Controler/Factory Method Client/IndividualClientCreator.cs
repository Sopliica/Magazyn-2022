using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazyn_2022.Model;
using Magazyn_2022.Model.Klienci;

namespace Magazyn_2022.Controler.Factory_Method_Client
{
    public class IndividualClientCreator : ClientCreator
    {
        public override IndividualClient Create()
        {
            IndividualClient individualClient = new IndividualClient();
            //tu sie robi
            return individualClient;
        }
    }
}