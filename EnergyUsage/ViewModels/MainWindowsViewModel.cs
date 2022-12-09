using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using EnergyUsage.Common;
using EnergyUsage.Common.Interfaces;
using EnergyUsage.Common.Repo;
using EnergyUsage.Models.ParrentClass;
using EnergyUsage.ViewModelBases;
using EnergyUsage.Views;

namespace EnergyUsage.ViewModels
{
    internal class MainWindowsViewModel : ViewModelBase
    {
        private IRepository _repository;

        public DelegateCommand OpenCommand { get; private set; }
        public DelegateCommand ExportCommand { get; private set; }

        internal MainWindowsViewModel(IRepository repository) 
        {
            _repository = repository;
            SetUpCommands();
        }

        private void SetUpCommands()
        {
            OpenCommand = new DelegateCommand(OpenInputWindow);
            ExportCommand = new DelegateCommand(ExportData);
        }

        private void ExportData()
        {
            Energy energy = new Energy(10,10,10);
            Export export = new Export(energy);
            export.SaveJson();



        }


        private void OpenInputWindow()
        {
            MessageBox.Show("open");
        }
    }
}
