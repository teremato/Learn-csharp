using System;
using System.Threading;

namespace _1000_7
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Сколько будет 1000 - 7?\n");
            Console.ReadKey();
            

            int result = 1007 - 7;
            
            while (result > 7)
            {
                Console.WriteLine($"... {result} - 7 = {result - 7}\n");
                result -= 7;
                Thread.Sleep(100);
                Console.Clear();
            }
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("` Я гуль... `");
                Thread.Sleep(100);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("`` Я гуль... ``");
                Thread.Sleep(100);
                Console.Clear();

            }
            

        }
    }
}
