using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give first number: ");
            string eka = Console.ReadLine();
            int first = int.Parse(eka);
            Console.Write("Give second number: ");
            string toka = Console.ReadLine();
            int second = int.Parse(toka);
            Console.Write("Give third number: ");
            string kolmas = Console.ReadLine();
            int third = int.Parse(kolmas);

            Console.WriteLine();
            Console.Write("Total is ");
            Console.WriteLine(first + second + third);
            Console.Write("Average is ");
            Console.WriteLine((first + second + third) / 3);

            Console.ReadLine();
        }
    }
}
