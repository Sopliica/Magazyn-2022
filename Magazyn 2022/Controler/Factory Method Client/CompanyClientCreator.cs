using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazyn_2022.Model.Klienci;

namespace Magazyn_2022.Controler.Factory_Method_Client
{
    public class CompanyClientCreator : ClientCreator
    {
        public override CompanyClient Create()
        {
            CompanyClient CompanyClient = new CompanyClient();
            //tu sie robi
            return CompanyClient;
        }
    }
}
