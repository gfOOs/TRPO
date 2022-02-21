using System;

namespace Лр8здн1

{

    class Program

    {

        struct Informashion //объявление структуру

        {

            public string nosit;

            public int v; //объявление и описание переменных

            public string name;

            public string autor;

            public void info() //объявление метода

            {

                Console.WriteLine("{0} имеет объём - {1}.Название данного носителя - {3}.Владелец - {2}", nosit, v, autor, name);//вывод текста на экран

            }

        }

        static void Main(string[] args)

        {

            Console.Write("Введите количество записей: ");//вывод текста на экран

            int n = int.Parse(Console.ReadLine());//ввод данных

            Informashion[] infor = new Informashion[n]; // объявление структуры и её описание

            Console.WriteLine("Заполним информацию про 3 носителя:");

            for (int i = 0; i < n; i++) //объявление цикла

            {

                Console.WriteLine((i + 1) + " носитель:");

                Console.Write("Носитель:");

                infor[i].nosit = Console.ReadLine();

                Console.Write("Объём:");

                infor[i].v = int.Parse(Console.ReadLine()); //заполнение структуры

                Console.Write("Название:");

                infor[i].name = Console.ReadLine();

                Console.Write("Автор:");

                infor[i].autor = Console.ReadLine();

            }

            Console.WriteLine("Информация о существующих носителях:");

            foreach (Informashion inf in infor)

            {

                inf.info(); //вывод данных структуры на экран

            }

            Console.WriteLine("Введите объём у носителя,который вы хотите удалить:");

            int obr_v = int.Parse(Console.ReadLine());

            int number = 0;

            for (int i = 0; i < n; i++) //объявление цикла

            {

                if (infor[i].v == obr_v) { number = i; } //проверка условия совпадения

            }

            for (int i = number; i < n - 1; i++)

            {

                for (int j = 0; j < n - number - 1; j++) //удаление данных из структуры

                {

                    infor[i] = infor[i + 1];

                }

            }

            foreach (Informashion inf in infor)

            {

                inf.info(); //вывод структуры на экран

            }

            Console.Write("Введите количество элементов, которое нужно добавить в структуру: ");

            int k = int.Parse(Console.ReadLine());

            Array.Resize(ref infor, n + k - 1); //изменения размера структуры

            Console.WriteLine("Заполним информацию про о новых носителях:");

            for (int i = n - 1; i < infor.Length; i++)

            {

                Console.WriteLine((i + 1) + " носитель:");

                Console.Write("Носитель:");

                infor[i].nosit = Console.ReadLine();

                Console.Write("Объём:");

                infor[i].v = int.Parse(Console.ReadLine()); //заполняем структуру до конца

                Console.Write("Название:");

                infor[i].name = Console.ReadLine();

                Console.Write("Автор:");

                infor[i].autor = Console.ReadLine();

            }

            foreach (Informashion inf in infor)

            {

                inf.info(); //вывод новой структуры на экран

            }

        }

    }

}
