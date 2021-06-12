using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praxis
{
    internal class Standardbehandlung : Behandlung
    {
       
        private readonly double _arthrose = 45.12;
        private readonly double _ultraschall = 26.80;

        public Standardbehandlung(string kvNummer, string beschreibung) : base(kvNummer, beschreibung)
        {
        }

        public override double GetKosten()
        {
            return Beschreibung == "Arthrose" ? _arthrose : _ultraschall;
        }
    }
}
