using PomidoraWins.Views;
using PomidoraWins.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomidoraWins.Farctory
{
    public static class PomidoraViewFactory
    {
        public static MainWindow GetMainWindow()
        {
            MainWindow ret = new MainWindow();
            ret.ViewModel = new PomidoraViewModel();
            return ret;
        }

        public static PomidoraCustomOptionsWindow GetCustomOptionsWindow()
        {
            PomidoraCustomOptionsWindow ret = new PomidoraCustomOptionsWindow();
            ret.ViewModel = new PomidoraCustomOptionsViewModel();
            return ret;
        }

        public static PomidoraOptionsWindow GetOptionsWindow()
        {
            PomidoraOptionsWindow ret = new PomidoraOptionsWindow();
            ret.ViewModel = new PomidoraOptionsViewModel();
            return ret;
        }
    }
}
