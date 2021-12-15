using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn_2022.Model
{
    public abstract class APack
    {
        private static int CurrentFreeId { get; set; } = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public int WidthInMeters { get; set; }
        public int HeightInMeters { get; set; }
        public int WeightInKilos { get; set; }
        public string AditionalInfo { get; set; }
        private int GetNewId()
        {
            CurrentFreeId++;
            return CurrentFreeId - 1;
        }
        APack()
        {
            this.Id = GetNewId();
        }
    }
}
