using System;

namespace Haromszog
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            Console.WriteLine("Kérem adja meg az a oldal hosszát: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem adja meg a b oldal hosszát: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem adja meg a c oldal hosszát: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Haromszog haromszog = new Haromszog(a, b, c);

            Console.WriteLine($"A háromszög kerülete: {haromszog.Kerulet()}");

            Console.WriteLine($"A háromszög területe: {haromszog.Terulet()}");

        }
    }
}
