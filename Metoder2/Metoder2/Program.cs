using System;

namespace Metoder2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 72, b = 24, c = 101;
            Console.WriteLine("Medelvärdet är "+(Medelvärde(a, b, c)));
        }
        static float Medelvärde(float x, float y, float z)
        {
            return ((x + y + z)/3);
        }
    }
}
