using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PomidoraWins.Enums;
using PomidoraWins.Models;

namespace PomidoraWins.Farctory
{
    public static class PomidoraSettingsFactory
    {
        private static Boolean IsSettingsRecivedFromTheConfig;
        public static PomidoraSettings GetPomidoraSettings()
        {
            PomidoraSettings ret = new PomidoraSettings();
            return ret;
        }

        public static void SetupSettings()
        {
            if (!IsSettingsRecivedFromTheConfig)
            {
                PomidoraSettings.StopTimeInMemory = new TimeSpan(
                       Properties.Settings.Default.Hours,
                       Properties.Settings.Default.Minutes,
                       Properties.Settings.Default.Seconds);
                PomidoraSettings.FlowInMemory = (PomidoraFlow)Properties.Settings.Default.Flow;
                IsSettingsRecivedFromTheConfig = true;
            }
        }

        public static void StoreSettings()
        {
            Properties.Settings.Default.Hours = PomidoraSettings.StopTimeInMemory.Hours;
            Properties.Settings.Default.Minutes = PomidoraSettings.StopTimeInMemory.Minutes;
            Properties.Settings.Default.Seconds = PomidoraSettings.StopTimeInMemory.Seconds;
            Properties.Settings.Default.Flow = (int)PomidoraSettings.FlowInMemory;
            Properties.Settings.Default.Save();
        }
    }
}
