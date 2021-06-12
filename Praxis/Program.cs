using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praxis
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var p = new Patient();
            var pM = new Hello();

            //AddBehandlung     Returns:VOID
            var sB1 = new Standardbehandlung("A1", "Arthrose");
            pM.AddBehandlung(sB1);
            var sB2 = new Standardbehandlung("A2", "Arthrose");
            pM.AddBehandlung(sB2);
            var pB1 = new Physiobehandlung("A3", "Chiropymnastik");
            pM.AddBehandlung(pB1);
            var pB2 = new Physiobehandlung("A4", "Waermeanwendung");
            pM.AddBehandlung(pB2);

            var sB3 = new Standardbehandlung("A1", "Arthrose");
            pM.AddBehandlung(sB1);

           

            //GetBehandlung     Returns:List<Behandlung> with given <kvNummer>

            foreach (var item in pM.GetBehandlung("A1"))
            {
                Console.WriteLine($"{item.KvNummer} {item.Beschreibung} {item.GetKosten()}");
            }

            //ErmittleKosten        Returns: double Kost of all 
            Console.WriteLine(pM.ErmittleKosten());

            //AnzBehandlung        Returns: int Number of Sessions of given <kvNummer>
            Console.WriteLine(pM.AnzBehandlung("A1"));
            object patientName = "Patient1";
            Console.WriteLine($"Hello {patientName} Wie geht es dir.");
            Console.ReadLine();
        }
    }
}