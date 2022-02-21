using System;

namespace LR13_14_3
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
            Console.WriteLine("\nНазвание изменилось!\n");
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
            Console.Write("Введите новое название - ");
            string news = Console.ReadLine();
            name = news;
            ev.ChangeName += new Changing(wr.Yes); //добавление обработчика события
            ev.OnChange(); //запуск события
            Console.WriteLine("Новое название автомобиля - {0}", name);
            Console.ReadKey();
        }
    }
}

