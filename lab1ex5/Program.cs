using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Program care va afisa in ordine crescatoare doua numere de la tastatura.*/

            int x;
            int y;

            Console.WriteLine("Introduceti primul numar:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar:");
            y = int.Parse(Console.ReadLine());


            if (x < y)
            {
                Console.Write("\n" + x + ";");
                Console.WriteLine(y);
            }
            else if (x > y)
            {
                Console.Write("\n" + y + ";");
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("\n" + "Cele doua numere sunt egale" + ".");
            }

        }
    }
}
