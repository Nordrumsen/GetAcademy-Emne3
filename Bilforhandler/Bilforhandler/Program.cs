using System;
using System.Collections.Generic;

namespace Bilforhandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bilforhandler bilforhandler = new Bilforhandler("BilButta", "Bilveien 240");
            GenererBiler(bilforhandler);
            Console.WriteLine("Alle bilene:");
            foreach(var bil in Bilforhandler.Biler) Console.WriteLine(bil.Merke + ", " + bil.År + ", " + bil.Kilometer + ", " + bil.RegNo);


            //returnerer en liste over alle biler som er mindre enn X år gamle
            List<Bil> gamleBiler = bilforhandler.HentGamleBiler(DateTime.Now.Year - 10); //Året vi er i minus 10
            Console.WriteLine("\n\nAlle biler som er mindre enn 10 år gamle:");
            foreach (var bil in gamleBiler) Console.WriteLine(bil.Merke + ", " + bil.År + ", " + bil.Kilometer + ", " + bil.RegNo);


            //returnerer en liste over alle biler som har kjørt mer enn Y kilometer
            List<Bil> kilometerBil = bilforhandler.HentNedkjørteBiler(200000);
            Console.WriteLine("\n\nAlle biler som har kjørt mindre enn 200.000km:");
            foreach (var bil in kilometerBil) Console.WriteLine(bil.Merke + ", " + bil.År + ", " + bil.Kilometer + ", " + bil.RegNo);


            //fjerner en bil fra listen over biler, basert på registreringsnummeret til bilen
            bilforhandler.fjernBil("ED 46425");
            Console.WriteLine("\n\nVi fjernet bilen med RegNo: ED 46425");

            //Hent alle bilene
            List<Bil> biler = bilforhandler.HentAlleBiler();
            Console.WriteLine("Alle bilene:");
            foreach (var bil in biler) Console.WriteLine(bil.Merke + ", " + bil.År + ", " + bil.Kilometer + ", " + bil.RegNo);

            Console.ReadKey(true);
        }

        static void GenererBiler(Bilforhandler bilforhandler)
        {
            bilforhandler.addBil("Volvo", "AA 42069", 2004, 143870); //+79,- for wunderbaum
            bilforhandler.addBil("Audi", "KH 13370", 2013, 173880);
            bilforhandler.addBil("Nissan", "BK 16110", 1999, 443870);
            bilforhandler.addBil("Tesla", "ED 46425", 2016, 368429);
            bilforhandler.addBil("Toyota", "AB 12345", 2005, 205746);
            bilforhandler.addBil("BMW", "CD 67890", 2020, 97400);
            //eller du kan gjøre sånn her :) 
            //Bil bil6 = new Bil("BMW", "CD 67890", 2020, 97400);
            //bilforhandler.addBil(bil6);
        }
    }
}