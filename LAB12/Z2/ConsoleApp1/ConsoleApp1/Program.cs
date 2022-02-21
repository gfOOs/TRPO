using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int notbyte = rnd.Next(-128, 128);
            byte bt;
            try
            {
                try
                {
                    checked
                    {
                        bt = (byte)notbyte;
                    }
                    Console.WriteLine(bt);
                }
                catch
                {
                    Console.WriteLine("Сработал внутренний обработчик.");
                    throw;
                }
            }
            catch
            {
                Console.WriteLine("Сработал внешний обработчик.");
            }
            finally
            {
                bt = (byte)notbyte;
                Console.WriteLine(bt);

            }

        }
    }
}
