using System;
using System.Collections.Generic;

namespace Samolot
{
    class Program
    {
        static void Main(string[] args)
        {
            string miejsca = Console.ReadLine();
            string[] numbers = miejsca.Split(" ");
            int n1 = Convert.ToInt32(numbers[0]);
            int n2 = Convert.ToInt32(numbers[2]);
            int k1 = Convert.ToInt32(numbers[1]);
            int k2 = Convert.ToInt32(numbers[3]);
            int suma = n1 * k1 + n2 * k2;
            Console.WriteLine(suma.ToString());
            
        }
    }
}
