using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyUsage.Models.ParrentClass
{
    abstract internal class EnergyBaseClass
    {
        public DateTime DayOfMeaurment { get; set; }

        enum Rooms
        {
            Küche,
            Flur,
            Wohnzimmer,
            Keller,
            Schlafzimmer,
        }
    }
}
