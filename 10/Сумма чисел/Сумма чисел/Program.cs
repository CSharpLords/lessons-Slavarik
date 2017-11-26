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
            int sum = 0;
            int SumN = 0;
            while (SumN < 4)
            {
                Console.WriteLine("Введите число");
                int number = int.Parse(Console.ReadLine());
                sum = number + sum;
                SumN = SumN + 1;
            }
            Console.WriteLine("Сумма чисел ровна:" + sum);
            Console.ReadLine();
        }
    }
}
