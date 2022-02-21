using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 11;
            int[] mass;
            mass = new int[n];
            Random rand = new Random();
            string message = "Текст ошибки: IndexOutOfRangeException";
            Console.WriteLine("Массив:");
            for (int k = 0; k < n; k++)
            {
                mass[k] = rand.Next(-10, n);
                Console.Write(mass[k] + " ");
            }
            Console.WriteLine();
            try
            {
                Console.WriteLine(mass[n]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine(message);
            }
            int i = 10 * n;
            int j = 5 + n;
            while (j != -10)
            {
                try
                {
                    Console.Write((i % j) + " ");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Делить на ноль нельзя!");
                }
                i += 3;
                j += -1;
            }
        }
    }
}
