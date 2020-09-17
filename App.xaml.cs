using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using PomidoraWins.Farctory;
using PomidoraWins.Views;

namespace PomidoraWins
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            PomidoraSettingsFactory.SetupSettings();
            MainWindow mainWindow = PomidoraViewFactory.GetMainWindow();
            mainWindow.ShowDialog();
            PomidoraSettingsFactory.StoreSettings();
        }
    }
}
