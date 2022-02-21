using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 12;
            while (a < b)
            {
                if (a % 2 == 0)
                    Console.Write("{0} ", a);
                a++;
            }
            Console.WriteLine();

            a = 1; b = 12;
            do
            {
                if (a % 2 == 0)
                    Console.Write("{0} ", a);
                a++;
            }
            while (a < b);
            Console.WriteLine();

            a = 1; b = 12;
            for (int i = a; i < b; i++)
            {
                if (i % 2 == 0)
                    Console.Write("{0} ", i);
            }

            Console.ReadLine();
        }
    }
}
