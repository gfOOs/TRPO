using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            Point gg = new Point(5, 6, 2);
            gg.Print();
            gg.Distance();
            Console.WriteLine("Расстояние от начала координат до точки = {0}", gg.Distance());
            gg.Move(2, -5);
            Console.WriteLine("Перемещение точки на вектор (а,b){0}", gg.Scalar(7));
            gg.Print();
            Console.WriteLine("Умножить координаты точки на скаляр");
            gg.Print();
            Console.WriteLine("Точка изменила координаты на +1 = {0}", ++gg);
            gg.Print();
            Console.WriteLine("Точка изменила координаты на -1 = {0}", --gg);
            gg.Print();
            Console.WriteLine("Проверка на равенсто х и у данной точки = {0}", gg.x == gg.y); //Хочу вывести на экран true или false
            Console.WriteLine("Добавление к полям х и у значение скаляра  {0}", gg + 5);
            gg.Print();
        }
    }
}