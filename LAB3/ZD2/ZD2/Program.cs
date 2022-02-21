using System;

namespace ZD2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1, j = 0; i < 6; i++)
            {
                for (int k = 0; k < i; k++)
                    Console.Write(i);
                Console.WriteLine();
                for (int k = 0; k < i; k++)
                    Console.Write(j);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        }
}
