using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Fx(a) > Fx(b) ? "В точке A" : "В точке B");
        }

        static double Fx(double x)
        {
            return Math.Pow(x, 3) + Math.Sin(x);
            Console.ReadLine();
        }
    }
}
