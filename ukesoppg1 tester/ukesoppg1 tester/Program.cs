using System;

namespace ukesoppg1_tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv navnet ditt: ");
            string navn = Console.ReadLine();

            Console.Write("Hei " + navn + ". Ønsker du en ny hobby? ");
            string jaNei = Console.ReadLine();

            string[] hobby = { "gaming ", "strikking ", "sykling ", "hekling ", "3D printing " };
            

            if (jaNei == "ja" || jaNei == "Ja" || jaNei == "JA") //jaNei.ToLower() == "ja" gjør det samme
            {
                Random rand = new Random();
                int num = rand.Next(0, hobby.Length);
                Console.WriteLine("Okey, jeg har funnet en hobby til deg " + navn + ", her er din nye hobby: " + hobby[num]);
                string tekst = Console.ReadLine();
                Console.WriteLine("Bare hyggelig " + navn + ". Ha en fin dag vidre! :)");
            }
            else
            {
                Console.WriteLine("Nei vel. Ha en fin dag vidre " + navn);
            }

            Console.ReadLine();
        }
    }
}
