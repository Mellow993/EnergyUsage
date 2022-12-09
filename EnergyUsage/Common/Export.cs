using EnergyUsage.Models.ParrentClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EnergyUsage.Common
{
    internal class Export
    {
        private readonly List<Energy> _energy;
        public Export(List<Energy> energy)
        {
            _energy = energy;
        }      
        
        public Export()
        {
        }

        public async void SaveJson()
        {
            await using FileStream createStream = File.Create(@"C:\Users\Lenovo\source\repos\BenfordSet\energy.json");
            await JsonSerializer.SerializeAsync(createStream,_energy);        }


    }
}
