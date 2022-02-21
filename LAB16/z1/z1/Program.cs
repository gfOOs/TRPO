using System;
using MyLibrary;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Певый массив
            Console.Write("Введите кол-во строк в массиве: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во столбцов в массиве: ");
            int m1 = int.Parse(Console.ReadLine());

            var a = new myArray(n1, m1);
            a.fillArray();
            a.showArray();
            Console.WriteLine($"{a.getSumOfCol(1)}");
            Console.WriteLine(a.amountOFNull);
            a++;
            a.showArray();

            //Индексация
            Console.Write("Введите индекс строки для поиска элемента: ");
            int arrRow = int.Parse(Console.ReadLine());
            Console.Write("Введите индекс стобца для поиска элемента: ");
            int arrCol = int.Parse(Console.ReadLine());
            Console.WriteLine($"Элемент: {a[arrRow, arrCol]}");

            if (a)
            {
                Console.WriteLine("Массив квадратный");
            }
            else
            {
                Console.WriteLine("Массив не квадратный");
            }

            //Второй массив
            Console.Write("Введите кол-во строк в массиве: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Введите кол-во столбцов в массиве: ");
            int m2 = int.Parse(Console.ReadLine());
            myArray b = new myArray(n2, m2);
            b.randomFillArray(0, 20);
            b.showArray();

            myArray c = a + b;
            c.showArray();


        }
    }
}
