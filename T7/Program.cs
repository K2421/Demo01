using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
//Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna vuosiluku: ");
            string eka = Console.ReadLine();
            int year = int.Parse(eka);

            if (year % 4 == 0 && year % 100 != 0) 
            {
                Console.WriteLine("On karkausvuosi!");

            }
            else if (year % 400 == 0) 
            {
                Console.WriteLine("On karkausvuosi!");

            }
            else
            {
                Console.WriteLine("Ei ole karkausvuosi!");

            }
            Console.ReadLine();
        }
    }
}
