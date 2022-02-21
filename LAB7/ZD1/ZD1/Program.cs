using System;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите исходную строку");
            string a = Console.ReadLine();
            Regex reg = new Regex(@"[A-Z]\S*");
            foreach (var i in reg.Matches(a))
                Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}