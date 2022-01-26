using System;
using System.Collections.Generic;

namespace PlusyiMinusy
{
    class Program
    {

        static void Main(string[] args)
        {
            string liczby;
            liczby = Console.ReadLine();
            int counter = 0;
            Char plus = '+';
            Char minus = '-';
            var oceny = new List<string>();

            for (int i = 0; i < liczby.Length; i++)
            {
                if (liczby[i] == plus)
                {
                    counter++;

                    if (counter == 3)
                    {
                        oceny.Add("5");
                        counter = 0;
                    }
                    
                }
                else if (liczby[i] == minus)
                {
                    counter--;

                    if (counter == -3)
                    {
                        oceny.Add("1");
                        counter = 0;
                    }
                }                
            }

            if (oceny.Count > 0)
            {
                Console.WriteLine(String.Join(" ", oceny));
            }

            else
            {
                Console.WriteLine("BRAK");
            }
        }
    }      
}
