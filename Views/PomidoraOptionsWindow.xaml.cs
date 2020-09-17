using PomidoraWins.Farctory;
using PomidoraWins.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PomidoraWins.Views
{
    /// <summary>
    /// Логика взаимодействия для PomidoraOptionsWindow.xaml
    /// </summary>
    public partial class PomidoraOptionsWindow : Window
    {
        private PomidoraOptionsViewModel viewModel;

        public PomidoraOptionsViewModel ViewModel
        {
            set
            {
                viewModel = value;
                this.DataContext = viewModel;
            }
        }

        public PomidoraOptionsWindow()
        {
            InitializeComponent();
        }

        private void CustomOptions_Click(object sender, RoutedEventArgs e)
        {
            PomidoraCustomOptionsWindow view = PomidoraViewFactory.GetCustomOptionsWindow();
            view.ShowDialog();
        }
    }
}
