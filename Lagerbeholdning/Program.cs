using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Lagerbeholdning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Klær klær1 = new Klær("Bukse", 45, 749, "Large", "rosa");
            Klær klær2 = new Klær("Kjole", 65, 549, "Small", "grønn");
            Klær klær3 = new Klær("Genser", 20, 299, "X Small", "blå");
            Klær klær4 = new Klær("Topp", 70, 149, "Large", "grå");
            Klær klær5 = new Klær("OnePiece", 12, 1099, "Small", "svart");

            Elektrisk elsktrisk1 = new Elektrisk("iPhone 13 pro Max", 14, 12500, "grå", "4 år");
            Elektrisk elsktrisk2 = new Elektrisk("Mikrobølgeovn", 5, 2500, "hvit", "3 år");
            Elektrisk elsktrisk3 = new Elektrisk("Støvsuger", 20, 4499, "svart", "2 år");
            Elektrisk elsktrisk4 = new Elektrisk("Kjøkkenmarskin", 7, 7849, "grå", "5 år");
        }
    }
}