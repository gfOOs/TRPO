using System;
using System.Linq;

namespace ZD3
{
    class Program
    {
        static void Main(string[] args)
        {
            // заданная строка
            Console.Write("Введите осмысленное сообщения: ");
            string s = Console.ReadLine();
            // Выведены те слова которые содержаттся хотя бы одна цифра
            string[] div = s.Split(' ', ',', '.', '-', '!', '?');
            for (int i = 0; i < div.Length; i++)
            {
                int count = div[i].Where(x => char.IsDigit(x)).Count();
                if (count.Equals(1))
                {
                    Console.WriteLine("Выведены те слова которые содержат хотя бы одну цифру: {0} ", div[i]);
                }
            }
            // выход из программы
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey(true);
        }
    }
}
