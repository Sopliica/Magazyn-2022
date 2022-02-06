using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazyn_2022.Controler.Factory_Method_Curier;

namespace Magazyn_2022.Model.Curiers
{
    public abstract class ACurier : ICurier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Surname{ get; set; }
        public string LicenceNumber { get; set; }
        public int AccesLvL { get; set; }
        public List<AOrder> OrderList { get; set; }
        public List<APack> PackList { get; set; }

        public List<AOrder> GetOrderList()
        {
            return OrderList;
        }

        public List<APack> GetPackList()
        {
            return PackList;
        }

        public void OrderReturned(AOrder order)
        {
            //dodaj zamowienie do listy zwroconych zamowien;
        }
    }
}
