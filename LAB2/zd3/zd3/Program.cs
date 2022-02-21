using System;

namespace zd3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер карты ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ваша карта - ");
            switch (a)
            {
                case 6:
                    Console.WriteLine("Шестерка");
                    break;
                case 7:
                    Console.WriteLine("Семерка");
                    break;
                case 8:
                    Console.WriteLine("Восьмерка");
                    break;
                case 9:
                    Console.WriteLine("Девятка");
                    break;
                case 10:
                    Console.WriteLine("Десятка");
                    break;
                case 11:
                    Console.WriteLine("Валет");
                    break;
                case 12:
                    Console.WriteLine("Дама");
                    break;
                case 13:
                    Console.WriteLine("Король");
                    break;
                case 14:
                    Console.WriteLine("Туз");
                    break;
            }
            Console.ReadKey();
        }
    }
}