using System;
using System.IO;

namespace Z15
{
    class MyArray
    {
        protected string[] arr;

        public MyArray(string str)
        {
            this.arr = str.Split(" ");
        }

        public string join (string separator)
        {
            string resStr = "";
            for (int i = 0; i < this.arr.Length; i++)
            {
                resStr += this.arr[i];
                if (i != this.arr.Length - 1)
                {
                    resStr += separator;
                }
            }
            return resStr;

        }

        public string[] sort()
        {
            for (int i = 0; i < this.arr.Length - 1; i++)
            {
                for (int j = 0; j < this.arr.Length - 1; j++)
                {
                    if (Convert.ToInt32(this.arr[j]) > Convert.ToInt32(this.arr[j + 1]))
                    {
                        string buf = this.arr[j];
                        this.arr[j] = this.arr[j + 1];
                        this.arr[j + 1] = buf;
                    }
                }
            }

            return this.arr;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream("E:\\Рабочий стол\\шарага\\с#v2\\ЛР 15\\numbersFile.txt", FileMode.Open, FileAccess.ReadWrite); //создаем файловый поток

            StreamReader reader = new StreamReader(file); // создаем «потоковый читатель» и связываем его с файловым потоком

            string str = reader.ReadToEnd();

            MyArray obj = new MyArray(str);
            var sortedArr = obj.sort();
            string resStr = obj.join(" ");

            StreamWriter writer = new StreamWriter(file); //создаем «потоковый писатель» и связываем его с файловым потоком
            writer.WriteLine(); //Записываем данные в файл
            writer.Write(resStr);
            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется

        }

        
    }
}
