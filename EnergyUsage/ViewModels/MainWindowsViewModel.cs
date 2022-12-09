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

        #region Fields
        private double _waterConsumption;
        private double _gasConsumption;
        private double _currentConsumption;
        private DateOnly _today;
        #endregion

        #region Properties
        public DateOnly Today
        {
            get => _today;
            set
            {
                if(_today != value)
                {
                    _today = value;
                    OnPropertyChanged(nameof(Today));
                }
            }
        }
        public double WaterConsumption
        {
            get => _waterConsumption;
            set
            {
                if(_waterConsumption != value)
                {
                    _waterConsumption = value;
                    OnPropertyChanged(nameof(WaterConsumption));
                }
            }
        }
        public double GasConsumption
        {
            get => _gasConsumption;
            set
            {
                if(_gasConsumption != value)
                {
                    _gasConsumption = value;
                    OnPropertyChanged(nameof(GasConsumption));
                }
            }
        }
        public double CurrentConsumption
        {
            get => _currentConsumption;
            set
            {
                if(_currentConsumption != value)
                {
                    _currentConsumption = value;
                    OnPropertyChanged(nameof(CurrentConsumption));
                }
            }
        }
        #endregion


        #region DelegateCommands

        public DelegateCommand OpenCommand { get; private set; }
        public DelegateCommand AddCommand { get; private set; }
        public DelegateCommand ExportCommand { get; private set; }
        public DelegateCommand ExitCommand { get; private set; }
        #endregion

        internal MainWindowsViewModel(IRepository repository)
        {
            _repository = repository;
            SetUpCommands();
        }

        private void SetUpCommands()
        {
            ExitCommand = new DelegateCommand(ExitProgramm);
            ExportCommand = new DelegateCommand(ExportData);
            AddCommand = new DelegateCommand(Add);
        }


        private void ExportData()
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

        #region Prviate Methods

        private void Add()
        {

        }
        private void ExitProgramm()
        {
            Application.Current.Shutdown();
        }
        #endregion

    }
}
