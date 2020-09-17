using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomidoraWins.Enums
{
    /// <summary>
    /// Enumerable for pomidora standard flow
    /// </summary>
    public enum PomidoraFlow
    {
        // User inputed custom pomidora
        Custom = 0,

        // Standard pomidora (25 min)
        Regular = 1,

        // Double pomidora (50 min)
        Double = 2,

        // Quadro pomidora (100 min)
        Quadro = 3
    }
}
