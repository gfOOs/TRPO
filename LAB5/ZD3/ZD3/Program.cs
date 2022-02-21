using System;

namespace ZD3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[4, 3];
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (A[i, j] > 0)
                        sum += A[i, j];
                }
            }
            Console.WriteLine("Сумма положительных элементов A[4,3] = " + sum);
        }
    }
}
