using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        // VERDIER OG REFERANSETYPER

        int tall = 1; // Bare hele tall

        float desimalTall = 1.01f; // nøyaktig
        double desimalTall2 = 1.32; // trenger ikke bokstav bak, men fortsatt desimaltall
        decimal desimalTall3 = 1.47M; // veldig nøyaktig

        char bokstav = 'a'; // kun en bokstav, enkelt fnutter
        string tekst = "Hei"; // masse tekst, må ha dobbelfnutter, refererer til 'tekst' et annet sted - vil 'tekst' endre verdien

        bool santUsant = true; // eller false

        int[] tallAray = { 1, 2, 3 }; // kan ikke legge til flere verdier i et Array, da må man lage ny liste
        string[] tekstArray = { "Hei","på","deg" }; // kan ikke legge til flere verdier i et Array, da må man lage ny liste
        List<int> liste = new List<int>(); // iste som ikke har noen verdier, men kan legges til nye 

        //VIDEO FRA YOUTUBE 

        string yourName = "Sandra";
        int yourAge = 22;

        Console.WriteLine("Mitt navn er " + yourName);
        Console.WriteLine("Jeg er " + yourAge + " år gammel");
            

        Console.Read();
        
        
        // RETURVERDI I METODE

        static int 




        static void Main(string[] args)
        {

        }
    }
}
