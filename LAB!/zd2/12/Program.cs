using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первый катет");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второй катет");
            int b = int.Parse(Console.ReadLine());
            int x = (a * a + b * b);
            double c = Math.Sqrt(x);
            Console.WriteLine("Гипотенуза={0:##.###}",c);
            Console.Read();
        }
    }
}
