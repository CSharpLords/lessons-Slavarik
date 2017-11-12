using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            while (true)
            {
                int number = rand.Next(0, 50);

                Console.WriteLine("Вот ваше число:" + number);
                Thread.Sleep(2000);
                Console.Clear();

                Console.WriteLine("Введите запомненое число");
                int guess = int.Parse(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("Ты просто...");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("ТЫ ТУПОЕ...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

        }
    }
}
