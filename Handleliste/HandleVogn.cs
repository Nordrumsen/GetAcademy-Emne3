using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handleliste
{
    internal class HandleVogn
    {
        public List<Produkter> myShoppingCartProducts { get; set; }
        public List<int> myShoppingCartCounts { get; set; }

        public HandleVogn()
        {
            myShoppingCartProducts = new List<Produkter>();
            myShoppingCartCounts = new List<int>();
        }
    }
}