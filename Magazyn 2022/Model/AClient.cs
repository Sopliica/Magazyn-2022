using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn_2022.Model
{
    public class AClient
    {
        private static int CurrentFreeId { get; set; } = 1;
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }  
        public int StreetNumber { get; set; }
        public string AditionalStreetInfo { get; set; } 
        
        private int GetNewId()
        {
            CurrentFreeId++;
            return CurrentFreeId - 1;
        }
        AClient()
        {
            this.Id = GetNewId();
        }
    }
}
