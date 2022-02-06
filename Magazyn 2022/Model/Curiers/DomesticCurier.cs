using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn_2022.Model.Curiers
{
    public class DomesticCurier : ACurier
    {
        public int Region { get; set; }
        public List<AOrder> PriorityOrders { get; set; }

        List<AOrder> GetPriorityOrdersList()
        {
            return PriorityOrders;
        }
    }
}
