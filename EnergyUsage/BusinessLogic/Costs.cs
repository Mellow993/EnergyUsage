using System;
using System.Collections.Generic;
using System.Text;

namespace EnergyUsage.BusinessLogic
{
    public class Costs
    {
        public int Price { get; set; }

        public int AddOneToPrice()
        {
            return Price + 1;
        }
    }
}
