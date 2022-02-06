using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazyn_2022.Model;

namespace Magazyn_2022.Controler.Factory_Method_Curier
{
    public interface ICurier
    {
        List<AOrder> GetOrderList();
        List<APack> GetPackList();
        void OrderReturned(AOrder order);
    }
}
