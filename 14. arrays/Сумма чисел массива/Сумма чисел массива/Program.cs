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
            int[] massif = { 14, 123, 111, 10 };
            int sum = 0;
            for (int num = 0; num < massif.Length; num = num + 1)
            {
                sum = sum + massif[num];
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
