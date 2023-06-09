using System;

namespace Krokodilleoppg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var poeng = 0;                 //var, ikke int 

            while (true)
            {
                var random = new Random();
                var no1 = random.Next(0, 12);
                var no2 = random.Next(0, 12);

                Console.WriteLine(no1 + " _ " + no2);
                var input = Console.ReadLine();

                if(input == "<" || input == ">" || input == "=") 
                { 
                    if ((no1 > no2 && input == ">") || (no1 < no2 && input == "<") || (no1 == no2 && input == "="))
                    {
                        poeng++;
                    } 
                    else
                    {
                        poeng--;
                    }
                    Console.WriteLine("Poeng: " + poeng);
                    }
                else
                {
                    Console.WriteLine(input + " er ikke et gyldig tegn");
                    return;
                }
            }
        } 
    }
} 



//Du skal bruke det du har lært til å programmere “krokodille spillet”

//For hver runde skal det printes ut til skjermen et random tall mellom 1-11,
//et mellomrom og et nytt tall mellom 1-11 med en underscore mellom slik at det ser sånn ut: 3 _ 5

//Brukeren kan skrive inn <, > eller =

//i tilfellet brukeren får 3 _ 5 vil svaret være <, altså 3 < 5

//Tallene må sjekkes om det første er større eller mindre eller lik det andre tallet,
//Det må verifiseres om brukeren har valgt riktig alternativ.
//Brukeren får et poeng per riktig svar, og mister et poeng per feil svar.
//Poengsummen printes til skjermen for hvert svar brukeren har gitt.
//Spillet avsluttes når brukeren skriver inn noe annet enn de tre alternativene