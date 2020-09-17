using PomidoraWins.Farctory;
using PomidoraWins.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace PomidoraWins.ViewModels
{
    public class PomidoraViewModel : INotifyPropertyChanged, IDisposable
    {
        private bool disposed = false;
        private TimeSpan time = new TimeSpan();
        private PomidoraCounter counter = new PomidoraCounter();

        public event PropertyChangedEventHandler PropertyChanged;

        public TimeSpan Time
        {
            get
            {
                return this.time;
            }

            set
            {
                this.time = value;
                NotifyPropertyChanged();
            }
        }

        public PomidoraViewModel()
        {
            counter.TimeChangedEvent += VisibleTimeChanged;
        }

        /// <summary>
        /// Start Pomidora
        /// </summary>
        public void start()
        {
            PomidoraSettings settings = PomidoraSettingsFactory.GetPomidoraSettings();
            counter.start(settings);
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void VisibleTimeChanged(TimeSpan time)
        {
            Time = time;
        }

        public void Dispose()
        {
            if (!disposed)
            {
                counter.TimeChangedEvent -= VisibleTimeChanged;
                disposed = true;
            }
        }
    }
}
