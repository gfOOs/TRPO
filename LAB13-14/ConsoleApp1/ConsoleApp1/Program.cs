using System;

namespace LR13_14_2
{
    class EventKeyArgs : EventArgs 
    {
        public ConsoleKeyInfo cki;
    }

    delegate void KeyHalder(object source, EventKeyArgs arg); 

    class KeyEvent //класс события
    {
        public event KeyHalder KeyPress; 

        public void OnPressKey(ConsoleKeyInfo ch) 
        {
            EventKeyArgs a = new EventKeyArgs();
            if (KeyPress != null)
            {
                a.cki = ch;
                KeyPress(this, a);
            }
        }
    }

    class WriteInf
    {
        public void WriteInfo(object source, EventKeyArgs arg) 
        {
            Console.WriteLine("{0}, Символ: {1}", arg.cki.Key, arg.cki.KeyChar);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            KeyEvent ev = new KeyEvent();
            WriteInf wr = new WriteInf();
            ConsoleKeyInfo cki;
            string Str = "";
            ev.KeyPress += new KeyHalder(wr.WriteInfo); 

            Console.WriteLine("Введите символы. \nF1 - остановка работы.");
            do
            {
                Console.Write("Введите символ. ");
                cki = Console.ReadKey(true);
                ev.OnPressKey(cki); 
                Str += cki.KeyChar;
            } while (cki.Key != ConsoleKey.F1);
        }
    }
}

