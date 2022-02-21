using System;

namespace ZD2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество последовательность -->");
            int Count = int.Parse(Console.ReadLine());
            string[] array = new string[Count];
            for (int i = 0; i < Count; i++)
            {
                Console.Write("Введите числа через пробел -->");
                string result = Console.ReadLine();
                array[i] = result;
            }
            for (int i = 0; i < array.Length; i++)
            {
                int min = int.MaxValue;
                string[] temp = array[i].Split(' ');
                for (int j = 0; j < temp.Length; j++)
                {
                    if (min > int.Parse(temp[j]))
                    {
                        min = int.Parse(temp[j]);
                    }
                    
                }
                Console.WriteLine("Минимальное {0} ",min);

            }
            Console.ReadLine();
        }
    }
}
