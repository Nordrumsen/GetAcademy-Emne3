using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv inn navnet ditt:");
            string name = Console.ReadLine();

            Console.WriteLine("\nSkriv inn alderen din:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSkriv inn adressen din:");
            string adresse = Console.ReadLine();

            Console.WriteLine("\n\nDin personlige informasjon:");
            Console.WriteLine($"Navn: {name}"); //flere måter å hente ut "navn"
            Console.WriteLine("Alder:" + age); //flere måter å hente ut "navn"
            Console.WriteLine("Adresse: {0}", adresse); //flere måter å hente ut "navn"
            Console.Read();
        }
    }
}