using PomidoraWins.Enums;
using PomidoraWins.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomidoraWins.ViewModels
{
    public class PomidoraOptionsViewModel
    {
        public PomidoraOptionsViewModel()
        {
            flow = PomidoraSettings.FlowInMemory;
        }

        private PomidoraFlow flow = PomidoraFlow.Regular;

        public PomidoraFlow Flow
        {
            get => flow;
            set
            {
                flow = value;
                PomidoraSettings.FlowInMemory = flow;
            }
        }
    }
}
