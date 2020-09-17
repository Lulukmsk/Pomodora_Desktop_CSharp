using PomidoraWins.Farctory;
using PomidoraWins.Models;
using PomidoraWins.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PomidoraWins.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PomidoraViewModel viewModel;

        public PomidoraViewModel ViewModel 
        {
            set
            {
                viewModel = value;
                this.DataContext = viewModel;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Start_OnClick(object sender, RoutedEventArgs e)
        {
            viewModel.start();
        }

        private void Options_Click(object sender, RoutedEventArgs e)
        {
            PomidoraOptionsWindow view = PomidoraViewFactory.GetOptionsWindow();
            view.ShowDialog();
        }
    }
}
