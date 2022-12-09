using EnergyUsage.Models.ParrentClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyUsage.Common
{
    internal class Export
    {
        private readonly Energy _energy;
        public Export(Energy energy)
        {
            _energy = energy;
        }      
        
        public Export()
        {
        }

        public void SaveJson()
        {

        }


    }
}
