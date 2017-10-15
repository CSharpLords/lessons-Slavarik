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
            Console.WriteLine("Введите первое число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int c = int.Parse(Console.ReadLine());
            if (a >= b && a >= c)
            {
                Console.WriteLine("Самое большое число:" + a);
            }
            else
            {
                if (b >= c)
                {
                    Console.WriteLine("Самое большое число:" + b);
                }
                else
                {
                    if (c >= b)
                    {
                        Console.WriteLine("Самое большое число:" + c);
                    }
                }
                    
            }

            Console.ReadLine();
        }
    }
}
