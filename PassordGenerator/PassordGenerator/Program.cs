using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (!SjekkInput(args))
            {
                Veiledningstekst();
                return;
            }
            else Console.WriteLine("Det funker som faen!");
        } 

        static bool SjekkInput(string[] args)
        {
            if (args.Length == 0)
            {
                return false;
            }

            if (args.Length == 2)
            {
                foreach (var tall in args[0])
                {
                    if (!char.IsDigit(tall))
                    {
                        return false;
                    }
                }
                foreach (var bokstav in args[1])
                {
                    var godkjenteTegn = "lLds";
                    if (!godkjenteTegn.Contains(bokstav))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static void Veiledningstekst()
        {
            var tekst = "PasswordGenerator  \r\n" +
                        "  Options:\r\n  - " +
                        "l = lower case letter\r\n  - " +
                        "L = upper case letter\r\n  - " +
                        "d = digit\r\n  - " +
                        "s = special character (!\"#¤%&/(){}[]\r\n" +
                        "Example: " +
                        "PasswordGenerator 14 lLssdd\r\n         " +
                        "Min. 1 lower case\r\n         " +
                        "Min. 1 upper case\r\n         " +
                        "Min. 2 special characters\r\n         " +
                        "Min. 2 digits";

            Console.WriteLine(tekst);
        }
    }
}

/*
https://getacademy.moodlecloud.com/mod/page/view.php?id=244
*/
