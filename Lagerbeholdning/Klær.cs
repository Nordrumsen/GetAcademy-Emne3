using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerbeholdning
{
    internal class Klær : Inventory
    {
        public string Størrelse { get; set; }
        public string Farge { get; set; }

        public Klær(string navn, int antall, int pris, string størrelse, string farge)
        {
            Navn = navn;
            Antall = antall;
            Pris = pris;

            Størrelse = størrelse;
            Farge = farge;
        }
    }
}