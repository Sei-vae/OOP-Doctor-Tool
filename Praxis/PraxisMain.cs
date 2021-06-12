using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Praxis
{
    class Hello
    {
        private List<Patient> _patientenListe = new List<Patient>();
        private List<Behandlung> _behandlungsListe = new List<Behandlung>();
        private Patient _p = new Patient();

        public List<Patient> GetPatient(string name)
        {
            return _patientenListe.Where(item => item.Name == name).ToList();
        }


        public List<Patient> GetPatient2(string name)
        {
            // return _behandlungsListe.FindAll(Patient => Patient.Name == name);
            return null;
        }

        public List<Behandlung> GetBehandlung(string kvNummer)
        {
            return _behandlungsListe.Where(item => item.KvNummer == kvNummer).ToList();
        }

        public int AnzBehandlung(string kvNummer)
        {
            return _behandlungsListe.Count(item => item.KvNummer == kvNummer);
        }

        public string ZeigePatienten(int anzBehandlungen)
        {
            return (from item in _patientenListe
                let result = AnzBehandlung(item.KvNummer)
                where result >= anzBehandlungen
                select item).Aggregate(string.Empty, (current, item) => current + (item.Name + ";"));
        }

        public void AddBehandlung(Behandlung b)
        {
            _behandlungsListe.Add(b);
        }



        public int NewFunktion()
        {
            return _behandlungsListe.Count(item => item.KvNummer == "A1");
        }

        public double ErmittleKosten()
        {
            return _behandlungsListe.Aggregate(0.0, (current, item) => current + item.GetKosten());
        }

        public void Hello1()
        {
            foreach (var VARIABLE in _behandlungsListe.Where(VARIABLE => VARIABLE.KvNummer == "A1"))
            {
                Console.WriteLine("hello");
            }
        }


        public void Hello2()
        {
            foreach (var variable in _behandlungsListe.Where(VARIABLE => VARIABLE.KvNummer == "A1"))
            {
                Console.WriteLine("hello");
            }
        }


        public List<Behandlung> NewFunktion1()
        {
            return _behandlungsListe.Where(p => p.Kostensatz == "A1").ToList();
        }

    }
    
}
