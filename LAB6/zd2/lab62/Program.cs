using System;

namespace lab62
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();
            Console.WriteLine("Введите подстроку для замены:");
            string x = Console.ReadLine();
            Console.WriteLine(input.Replace(x, x + x));
            Console.ReadLine();
        }
    }
}
