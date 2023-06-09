using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukesoppgave_3
{
    public class VirituelleDyr
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }

        public VirituelleDyr(string name, int age, string type)
        {
            Name = name;
            Age = age;
            Type = type;
        }
    }

    //Lag en konsoll applikasjon hvor man kan generere opp flere forskjellige virtuelle kjæledyr.
    //Bruk constructor i klassen, og man skal ikke ha lov til å endre data som navn, age eller noen
    //  andre characteristics utenfra klassen.

    //Lag funksjonalitet som gjør at man kan gi dyret mat, bruk en overload til å gi en annen
    //  feedback til console dersom det er favorittmaten til dyret - f eks “Hurra dette er det beste jeg
    //  vet tusen takk for maten!” istedenfor f.eks “Takk for maten”.
}
