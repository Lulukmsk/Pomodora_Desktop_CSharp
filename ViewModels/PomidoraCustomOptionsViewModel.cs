using PomidoraWins.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomidoraWins.ViewModels
{
    public class PomidoraCustomOptionsViewModel
    {
        public PomidoraCustomOptionsViewModel()
        {
            hours = PomidoraSettings.StopTimeInMemory.Hours;
            minutes = PomidoraSettings.StopTimeInMemory.Minutes;
            seconds = PomidoraSettings.StopTimeInMemory.Seconds;
        }

        private int hours = 0;
        private int minutes = 0;
        private int seconds = 0;

        public int Hours 
        { 
            get => hours;
            set
            {
                hours = value;
                PomidoraSettings.StopTimeInMemory = new TimeSpan(value, PomidoraSettings.StopTimeInMemory.Minutes, PomidoraSettings.StopTimeInMemory.Seconds);
            }
        }

        public int Minutes
        {
            get => minutes;
            set
            {
                minutes = value;
                PomidoraSettings.StopTimeInMemory = new TimeSpan(PomidoraSettings.StopTimeInMemory.Hours, value, PomidoraSettings.StopTimeInMemory.Seconds);
            }
        }

        public int Seconds
        {
            get => seconds;
            set
            {
                seconds = value;
                PomidoraSettings.StopTimeInMemory = new TimeSpan(PomidoraSettings.StopTimeInMemory.Hours, PomidoraSettings.StopTimeInMemory.Minutes, value);
            }
        }
    }
}
