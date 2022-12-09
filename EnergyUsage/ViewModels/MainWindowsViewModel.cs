using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using EnergyUsage.Common.Interfaces;
using EnergyUsage.Common.Repo;
using EnergyUsage.ViewModelBases;
using EnergyUsage.Views;

namespace EnergyUsage.ViewModels
{
    internal class MainWindowsViewModel : ViewModelBase
    {
        private IRepository _repository;
        public DelegateCommand OpenCommand { get; private set; }

        internal MainWindowsViewModel(IRepository repository) 
        {
            //_iView = iView;
            _repository = repository;
            SetUpCommands();
        }

        private void SetUpCommands()
        {
            OpenCommand = new DelegateCommand(OpenInputWindow);
        }
        
        private void OpenInputWindow()
        {
            MessageBox.Show("open");
        }
    }
}
