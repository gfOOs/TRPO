using System;

namespace ZD1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N];
            Random rand = new Random();
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < N; i++)
            {
                arr[i] = rand.Next(0, 10);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Преобразованный массив: ");
            for (int i = 0; i < N; i++)
            {
                if (arr[i] < num) arr[i] = (int)Math.Pow(arr[i], 2);
                Console.Write(arr[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
