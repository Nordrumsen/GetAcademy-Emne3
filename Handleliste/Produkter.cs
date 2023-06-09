using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handleliste
{
    internal class Produkter
    {
        public string productNames { get; set; }
        public int productPrices { get; set; }

        public Produkter(string names, int prices)
        {
            productNames = names;
            productPrices = prices;
        }
    }
}