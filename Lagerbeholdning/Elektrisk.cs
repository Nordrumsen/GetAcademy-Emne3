using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerbeholdning
{
    internal class Elektrisk : Inventory
    {
        public string Farge { get; set; }
        public string Forsikring { get; set; }


        public Elektrisk(string navn, int antall, int pris, string farge, string forsikring)
        {
            Navn = navn;
            Antall = antall;
            Pris = pris;

            Farge = farge;
            Forsikring = forsikring;
        }
    }
}