using System;

namespace DodawanieLiczbCałkowitych
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int wynik;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            wynik = a + b + c;
            Console.WriteLine(wynik);

        }
    }
}
