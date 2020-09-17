using PomidoraWins.Helpers;
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
    public partial class PomidoraCustomOptionsWindow : Window
    {
        private PomidoraCustomOptionsViewModel viewModel;

        public PomidoraCustomOptionsViewModel ViewModel
        {
            set
            {
                viewModel = value;
                this.DataContext = viewModel;
            }
        }

        public PomidoraCustomOptionsWindow()
        {
            InitializeComponent();
        }

        private void Hours_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            PomidoraCustomOptionsHelper.PomidoraHandleResctiction(e, PomidoraCustomOptionsHelper.PomidoraHourSettingsRestictionRegex);
        }

        private void Minutes_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            PomidoraCustomOptionsHelper.PomidoraHandleResctiction(e, PomidoraCustomOptionsHelper.PomidoraMinutesAndSecondsSettingsRestictionRegex);
        }

        private void Seconds_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            PomidoraCustomOptionsHelper.PomidoraHandleResctiction(e, PomidoraCustomOptionsHelper.PomidoraMinutesAndSecondsSettingsRestictionRegex);
        }

        private void TextBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Dispatcher.BeginInvoke(new Action(() => tb.SelectAll()));
        }
    }
}
