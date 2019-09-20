using System;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            double radie = 2.4;
            Console.WriteLine("Cirkelns omkrets: " + CirkelOmkrets(radie));
            Console.WriteLine("Cirkelns area: " + CirkelArea(radie));
        }
        static double CirkelOmkrets(double r)
        {
            return (r * 2 * 3.14);
        }
        static double CirkelArea(double r)
        {
            return (r * r * 3.14);
        }
    }
}
