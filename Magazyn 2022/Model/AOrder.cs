using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn_2022.Model
{
    public abstract class AOrder
    {
        private static int CurrentFreeId { get; set; } = 1;
        public int Id { get; set; }
        //public Client Sender { get; set; } jak zrobie to odkomentowac oba
        //public Client Adresser { get; set; }
        public AUser Curier { get; set; }
        public DateTime DateOfOrder { get; set; }  
        public DateTime DateOfArrival { get; set; } 
        public bool Delivered { get; set; }
        private int GetNewId()
        {
            CurrentFreeId++;
            return CurrentFreeId - 1;
        }
        AOrder()
        {
            this.Id = GetNewId();
        }
    }
}
