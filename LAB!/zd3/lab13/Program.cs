using System;

namespace lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int num = int.Parse(Console.ReadLine());
                bool ch = num % 11 == 0;
                Console.WriteLine(ch);
                Console.ReadLine();
            }
        }
    }
}
