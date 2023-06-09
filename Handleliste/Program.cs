using Handleliste;

namespace Handleliste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleShoppingCartDemo.Run();
        }

        static void Varer()
        {
            Produkter A = new Produkter("A", 40);
            Produkter B = new Produkter("B", 70);
            Produkter C = new Produkter("C", 30);
        }
    }
}