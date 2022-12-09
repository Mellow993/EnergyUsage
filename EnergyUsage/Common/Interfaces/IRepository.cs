using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyUsage.Common.Interfaces
{
    internal interface IRepository
    {
        void Delete(object obj);
        void Save(object obj);
    }
}
