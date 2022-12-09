using EnergyUsage.Models.ParrentClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyUsage.Models.ChildClasses
{
    internal class Current : EnergyBaseClass
    {
        public double kWh { get; set; }
    }
}
