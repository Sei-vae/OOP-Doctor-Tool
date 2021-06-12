using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praxis
{
    internal class Physiobehandlung : Behandlung
    {
        private readonly double _chiroymnastik = 12.87;
        private readonly double _waermeanwendung = 4.23;

        public Physiobehandlung(string kvNummer, string beschreibung) : base(kvNummer,beschreibung)
        {
        }

        public override double GetKosten()
        {
            return Beschreibung == "Chiropymnastik" ? _chiroymnastik : _waermeanwendung;
        }
    }
}
