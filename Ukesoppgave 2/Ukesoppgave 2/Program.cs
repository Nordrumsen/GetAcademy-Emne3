using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ukesoppgave_2
{
    internal class Program
    {
        static List<Student> studentList;

        private static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //for å bruke æøå
            Init();
        }

        private static void Init()
        {
            studentList = new List<Student>
            {
                new Student("Hei Bernt", 42, "Radiobilkjøring"),
                new Student("Arne Kåre", 30, "Rekefisking"),
                new Student("Kurt Josef", 49, "Rekefisking"),
                new Student("Johnny Bjørn", 62, "Pølsespising"),
                new Student("Burt Erik", 58, "Pølsespising")
            };
            Start();
        }

        private static void Start()
        {
            var kursListe = new List<string>();
            foreach (Student student in studentList)
            {
                kursListe.Add(student.Kurs);
            }

            Console.WriteLine("Skriv 'exit' når som helst for å avslutte.\n\nVelg et kurs\nTilgjengelige kurs:");

            var midlertidigListe = new List<string>();
            foreach (string kurs in kursListe)
            {
                if (midlertidigListe.Contains(kurs))
                {
                    continue;
                }

                midlertidigListe.Add(kurs);
                Console.WriteLine(kurs);
            }

            Console.WriteLine();
            KursOversikt();
        }

        private static void KursOversikt()
        {
            var run = true;
            while (run)
            {
                var valgtKurs = Console.ReadLine().ToLower();
                if (valgtKurs.Contains("exit")) run = false;
                Console.WriteLine();

                foreach (Student enkeltStudent in studentList)
                {
                    if (enkeltStudent.Kurs.ToLower().Contains(valgtKurs))
                    {
                        Console.WriteLine(enkeltStudent.Navn + ", " + enkeltStudent.Alder + ", " + enkeltStudent.Kurs);
                    }
                }

                Console.WriteLine();
            }
        }
    }
}