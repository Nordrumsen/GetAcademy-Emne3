using System;
using System.Collections.Generic;

namespace Bilforhandler
{
    public class Bilforhandler
    {
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public static List<Bil>? Biler { get; set; }

        public Bilforhandler(string navn, string adresse)
        {
            Navn = navn;
            Adresse = adresse;
            Biler = new List<Bil>();
        }

        public void addBil(Bil bil)
        {
            Biler.Add(bil);
        }

        //bilforhandler.addbil(), snakker med denne:
        public void addBil(string merke, string regNo, int år, int kilometer)
        {
            Biler.Add(new Bil(merke, regNo, år, kilometer));
        }

        public void fjernBil(string regNo)
        {
            foreach(var bil in Biler)
            {
                if (bil.RegNo == regNo) 
                { 
                    Biler.Remove(bil);
                    return;
                }
            }
        }

        public List<Bil> HentGamleBiler(int minsteGodkjenteÅrgang)
        {
            var midlertidigListe = new List<Bil>();

            foreach (var bil in Biler)
            {
                if (bil.År >= minsteGodkjenteÅrgang) 
                    midlertidigListe.Add(bil);
            }
            return midlertidigListe;
        }

        public List<Bil> HentNedkjørteBiler(int maksKilometerstand)
        {
            var midlertidigListe = new List<Bil>();

            foreach (var bil in Biler)
            {
                if (bil.Kilometer !> maksKilometerstand)
                    midlertidigListe.Add(bil);
            }
            return midlertidigListe;
        }

        public List<Bil> HentAlleBiler()
        {
            return Biler;
        }
    }
}