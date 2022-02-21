using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            int c = int.Parse(Console.ReadLine());
            int x = a + b + c;
            Console.WriteLine( "{0}+{1}+{2}={3}",a,b,c,x );
            Console.ReadLine();

        }
    }
}
