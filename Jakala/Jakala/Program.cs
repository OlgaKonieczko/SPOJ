using System;
using System.Collections.Generic;
using System.Linq;

namespace Jakala
{
    class Program
    {
        static void Main(string[] args)
        {
           int liczba = Convert.ToInt32(Console.ReadLine());
           string litery = Console.ReadLine();
           string[] tablicaLiter = litery.Split(" ");
           string wyraz = Console.ReadLine();
           string[] wyraz2 = wyraz.Split("");
           List<string> wyjscie = new List<string>();
           int n = 0;

            foreach (Char i in wyraz)
            {
                if (tablicaLiter.Contains(i.ToString()))
                {
                    wyjscie.Add(i.ToString());
                    wyjscie.Add(i.ToString());

                }

                else
                {
                    wyjscie.Add(i.ToString());

                    if (n < liczba)
                    {
                        n++;
                    }
                }    

            }
            
            Console.WriteLine(String.Join("", wyjscie));

        }
    }
}
