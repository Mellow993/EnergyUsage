using EnergyUsage.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyUsage.Common.Repo
{
    internal class Repository : IRepository, IDisposable
    {
        private bool _alreadyDisposed;
        internal Repository()
        {

        }

        public void Delete(object obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Dispose(true); 
        }

        protected virtual void Dispose(bool disposing)
        {
            if(_alreadyDisposed)
                return;
            
            if(disposing)
            {
                //_object.Dispose();
                _alreadyDisposed = true;
            }

        }

        public void Save(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
