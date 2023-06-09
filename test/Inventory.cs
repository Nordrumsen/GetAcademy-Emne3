using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test;

namespace Lagerbeholdning
{
    internal class Inventory : ISellable
    {
        public string Navn { get; set; }
        public int Antall { get; set; }
        public int Pris { get; set; }

        public int KalkulerPris()
        {
            return Antall * Pris;
        }
    }
}