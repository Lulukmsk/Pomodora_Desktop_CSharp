using PomidoraWins.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomidoraWins.Models
{
    public class PomidoraSettings
    {
        private static PomidoraFlow flow = PomidoraFlow.Regular;
        private static TimeSpan stopTimeInMemory = new TimeSpan(0, 0, 0, 25, 0);
        private static string pomidorkaWAVInMemory = @"alarm.wav";
        private TimeSpan stopTime = stopTimeInMemory;
        private string pomidorkaWAV = pomidorkaWAVInMemory;

        public static TimeSpan StopTimeInMemory { get => stopTimeInMemory; set => stopTimeInMemory = value; }
        public static string PomidorkaWAVInMemory { get => pomidorkaWAVInMemory; set => pomidorkaWAVInMemory = value; }
        public static PomidoraFlow FlowInMemory { get => flow; set => flow = value; }

        public TimeSpan StopTime { get => stopTime; }
        public string PomidorkaWAV { get => pomidorkaWAV; }
        public PomidoraFlow Flow { get => flow; }
    }
}
