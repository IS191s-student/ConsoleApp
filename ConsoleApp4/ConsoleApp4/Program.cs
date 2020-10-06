using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A0 = (35 / G * 1) * cos(Z * v * c * w) + G * 1 * a - (a + sin(Z * v * c * w)) / a");
            Console.WriteLine("Введите G:");
            float G = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите a:");
            float a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите Z:");
            float Z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите v:");
            float v = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите c:");
            float c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите w:");
            float w = Convert.ToInt32(Console.ReadLine());

            double cos = Math.Cos(Z*v*c*w);
            double sin = Math.Sin(Z * v * c * w);

            double A0 = (35 / G*1) * cos + G*1 * a - (a + sin) / a;

            Console.WriteLine("Колличество символов после запятой:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A0 = {0}", Math.Round(A0, n));
            Console.ReadKey();
        }
    }
}
