using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyUsage.Models.ParrentClass
{
    internal class Energy
    {
        public DateTime DayOfMeaurment { get; set; }
        public double AmountOfWater { get; set; }
        public double AmountOfGas { get; set; }
        public double AmountOfCurrent { get; set; }

        enum Rooms
        {
            Küche,
            Flur,
            Wohnzimmer,
            Keller,
            Schlafzimmer,
        }

        public Energy(double amountOfWater, double amountOfGas, double amountOfCurrent)
        {
            //DayOfMeaurment = dayOfMeaurment;
            AmountOfWater = amountOfWater;
            AmountOfGas = amountOfGas;
            AmountOfCurrent = amountOfCurrent;
        }
    }
}
