using EnergyUsage.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyUsage.Common.Factory
{
    internal class Factory 
    {
        public static Factory Create()
        {
            return new Factory();
        }
    }
}
