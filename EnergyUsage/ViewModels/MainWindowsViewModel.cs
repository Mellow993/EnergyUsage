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
        List<Energy> EngeryObjects = new List<Energy>();

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
            //ExportCommand = new DelegateCommand(ExportData);
        }

        private void OpenInputWindow()
        {
            Energy energy = new Energy(10,10,10);
            Energy energy2 = new Energy(10,10,10);
            Energy energy3 = new Energy(10,10,10);
            Energy energy4 = new Energy(10,10,10);

            EngeryObjects.Add(energy);
            EngeryObjects.Add(energy2);
            EngeryObjects.Add(energy3);
            EngeryObjects.Add(energy4);

            Export export = new Export(EngeryObjects);
            export.SaveJson();



        }


        //private void OpenInputWindow()
        //{
        //    MessageBox.Show("open");
        //}
    }
}
