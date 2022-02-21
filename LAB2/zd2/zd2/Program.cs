using System;

namespace zd2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("x=");
                float x = float.Parse(Console.ReadLine());
                Console.Write("y=");
                float y = float.Parse(Console.ReadLine());
                if (x * x > -7 && x * x <= -7 && y * y <= -1)
                    Console.WriteLine("внутри");
                else if (x * x < -7 || y * y > -1)
                    Console.WriteLine("вне");
                else Console.WriteLine("на границе");
                Console.ReadKey();
            }
        }
    }
}
