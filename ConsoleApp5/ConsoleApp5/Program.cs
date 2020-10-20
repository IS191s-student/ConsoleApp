using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите колличество шагов");
            int sh = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите X");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите Y");
            int y = Convert.ToInt32(Console.ReadLine());

            int xn = 0;

            int yn = 1;

            double a = 0;
            double b = 0;

            for (int i = 1; i <= sh; i++)
            {
                xn = xn + 2;
                yn = yn + 2;

                double sin = Math.Sin(x ^ xn);
                double cos = Math.Cos(y ^ yn);

                double nsin = sin / xn;
                double ncos = cos / yn;

                 a += nsin;
                 b += ncos;
            }

            double Z = 1 - a + b;
            Console.WriteLine(Z);




        }
    }
}
