using System;

namespace ZD3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = Double.Parse(Console.ReadLine());
            Console.Write("h= ");
            double h = Double.Parse(Console.ReadLine());
            double y = 0;
            int i = 1;
            Console.WriteLine("{0,3} {1,5} {1,5}", "#", "x", "f(x)");

            for (double x = a; x <= b; x += h, ++i)
            {
                if (x < a)
                {
                    y = 0;
                }
                else if (x > a)
                {
                    y = ((x - a) / (x+a));
                }
                else if (x == a)
                {
                    y = 1;
                }
                Console.WriteLine("{0,3} {1,5:f2} {2,5:f2}", i, x, y);
            }
            Console.ReadKey();

        }
    }
}
