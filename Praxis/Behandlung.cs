using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praxis
{
    abstract class Behandlung
    {
        public string KvNummer { get; private set; }
        public string Beschreibung { get; private set; }
        public string Kostensatz { get;}

        protected Behandlung(string kvNummer,string beschreibung)
        {
            KvNummer = kvNummer;
            Beschreibung = beschreibung;
        }
        public abstract double GetKosten();
    }
}
