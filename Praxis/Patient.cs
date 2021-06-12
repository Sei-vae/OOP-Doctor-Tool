using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praxis
{
    internal class Patient
    {
        /// <summary>
        /// Actually the first name of the Patient.
        /// </summary>
        /// <param name="name"></param>
        
        public Patient(string name)
        {
            Name = name;
        }

        public Patient()
        {
        }

        //private string kvNummer;
        //private string name;
        //private string vorname;

        public string KvNummer { get;  }
        public string Name { get; }
        public string Vorname { get;  }
    }
}
