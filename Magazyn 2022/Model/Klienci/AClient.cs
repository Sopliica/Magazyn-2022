using Magazyn_2022.Controler.Factory_Method_Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn_2022.Model.Klienci
{
    public abstract class AClient : IClient
    {
        private static int CurrentFreeId { get; set; } = 1;
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }  
        public int StreetNumber { get; set; }
        public string AditionalStreetInfo { get; set; } 
        public int PhoneNumber { get; set; }    
        public string Email { get; set; }
        public AClient()
        {
            this.Id = GetNewId();
        }
        private int GetNewId()
        {
            CurrentFreeId++;
            return CurrentFreeId - 1;
        }
    }
}
