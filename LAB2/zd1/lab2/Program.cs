using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x=");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine(f(x));
            Console.ReadLine();
        }
        static double f(double x)
        {
            return Math.Sqrt(x*x-1);
        }
    }
}
