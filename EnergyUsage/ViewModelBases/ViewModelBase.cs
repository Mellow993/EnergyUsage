using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EnergyUsage.ViewModelBases
{
    internal class ViewModelBase
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propname = "")
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propname));
        }
    }
}
