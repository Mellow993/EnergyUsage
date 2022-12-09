using EnergyUsage.Common.Interfaces;
using EnergyUsage.Common.Repo;
using EnergyUsage.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EnergyUsage
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //protected override Window CreateShell()
        //{
        //    return Container.Resolve<System.Windows.Shell>();
        //}
        //protected override void RegisterTypes(IContainerRegistry containerRegistry)
        //{
        //    containerRegistry.Register<IWindowView, WindowToOpen>();

        //}

        public void Application_Startup(object sender, StartupEventArgs e)
        {
            IRepository repository = new Repository();
            MainWindowsViewModel mainWindowsViewModel = new MainWindowsViewModel(repository);
            MainWindow view = new MainWindow();
            view.DataContext = mainWindowsViewModel;
            view.Show();
        }
    }
}
