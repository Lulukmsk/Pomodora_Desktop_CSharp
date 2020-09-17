using PomidoraWins.Enums;
using PomidoraWins.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomidoraWins.Helpers
{
    public static class PomidoraSettingsHelper
    {
        public static TimeSpan GetStopTimeFromSettings(PomidoraSettings settings)
        {
            TimeSpan ret;
            switch (settings.Flow)
            {
                case PomidoraFlow.Double:
                    ret = new TimeSpan(0, 50, 0);
                    break;
                case PomidoraFlow.Quadro:
                    ret = new TimeSpan(1, 40, 0);
                    break;
                case PomidoraFlow.Custom:
                    ret = settings.StopTime;
                    break;
                case PomidoraFlow.Regular:
                default:
                    ret = new TimeSpan(0, 25, 0);
                    break;
            }
            return ret;
        }
    }
}
