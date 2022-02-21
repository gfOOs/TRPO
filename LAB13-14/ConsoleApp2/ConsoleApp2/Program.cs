using System;

namespace LR13_14_4
{
    delegate void Changing(); //делегат

    class EventClass
    {
        public event Changing ChangeName; //объявление события

        public void OnChange() //событие
        {
            if (ChangeName != null)
            {
                ChangeName();
            }
        }
    }

    class WriteInf
    {
        public void Yes() //обработчик события
        {
            Console.Write("Название изменилось! ");
        }
        public void No() //обработчик события
        {
            Console.Write("Название не изменилось!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ford";
            EventClass ev = new EventClass();
            WriteInf wr = new WriteInf();

            Console.WriteLine("Название автомобиля - {0}", name);

            Console.WriteLine("\n Изменить название автомобиля? (<да - клавиша <Y>, нет - клавиша <N>) \n");
            ConsoleKeyInfo cki;
            cki = Console.ReadKey(true);
            if (cki.Key == ConsoleKey.Y)
            {
                Console.Write("Введите новое название: ");
                string news = Console.ReadLine();
                name = news;
                ev.ChangeName += new Changing(wr.Yes); //добавление обработчика события
                ev.OnChange(); //запуск события
            }
            else if (cki.Key == ConsoleKey.N)
            {
                ev.ChangeName += new Changing(wr.No); //добавление обработчика события
                ev.OnChange(); //запуск события
            }
            else
            {
                Console.WriteLine("Введён неверный символ");
                Console.ReadKey();
                Environment.Exit(0);

            }

            Console.WriteLine(" Название автомобиля: {0}", name);
        }
    }
}

