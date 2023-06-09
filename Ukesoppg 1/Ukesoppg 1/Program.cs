using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukesoppg_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv navnet ditt, så får du en hobby som passer deg: ");

            string navn = Console.ReadLine();
            string[] hobby = { "gaming ", "strikking ", "sykling ", "hekling ", "3D printing " };

            Random rand = new Random();
            int num = rand.Next(0, hobby.Length);

            Console.WriteLine("Hei " + navn + ". Her er en hobby som passer for deg: " + hobby[num]);
            
            Console.ReadLine();
        }

    }
    
}
