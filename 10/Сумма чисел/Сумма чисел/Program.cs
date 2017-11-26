using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите первое число");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите первое число");
                int number2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите первое число");
                int number3 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите первое число");
                int number4 = int.Parse(Console.ReadLine());
                int sum = number + number2 + number3 + number4;
                Console.WriteLine("Сумма чисел ровна:" + sum);
                Console.WriteLine();
            }
        }
    }
}
