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
            int[] Massif = { 1, 3, 2, 3, 5, 6, 7, 8, 4, 5, 6, 2, 9, 1, 2, 6, 3, 5, 2, 1 };
            for (int n = 0; n < Massif.Length; n++)
            {
                if (Massif[n] < 3)
                {
                    Console.WriteLine("У команды:" + n + "-меньше 3 побед ");
                }
            }
            Console.ReadLine();
        }
    }
}
