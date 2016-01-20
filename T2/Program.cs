using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        //Ohjelma antaa arvosanan pisteiden mukaan
        static void Main(string[] args)
        {
            Console.WriteLine("Anna pistemäärä:  ");
            string rivi = Console.ReadLine();
            int pisteet = int.Parse(rivi);

            if(pisteet == 0 || pisteet == 1)
            {
                Console.WriteLine("Arvosana on 0"); 
            }
            else if(pisteet == 2 || pisteet == 3)
            {
                Console.WriteLine("Arvosana on 1");
            }
            else if(pisteet == 4 || pisteet == 5)
            {
                Console.WriteLine("Arvosana on 2");
            }
            else if(pisteet == 6 || pisteet == 7)
            {
                Console.WriteLine("Arvosana on 3");
            }
            else if(pisteet == 8 || pisteet == 9)
            {
                Console.WriteLine("Arvosana on 4");
            }
            else if (pisteet == 10 || pisteet == 11 || pisteet == 12)
            {
                Console.WriteLine("Arvosana on 5");
            }
        }
    }
}
