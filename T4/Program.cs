using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give age: ");
            string line = Console.ReadLine(); // "50" merkkijono
            int age = int.Parse(line); // 50 muuttaa merkkijonon numeroksi

            if (age < 18)
            {
                Console.WriteLine("You are an underage.");

            } else if (age >= 18 && age <= 65)
            {
                Console.WriteLine("You are an adult.");

            } else
            {
                Console.WriteLine("You are a senior");
            }
            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();

        }
    }
}
