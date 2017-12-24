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
            int[] Massif = { 4, 1, 2, 3, 5, 4, 5 };
            for (int n = 0; n < Massif.Length; n = n + 1) 
            {
                if (Massif[n] == 5)
                {
                    Console.WriteLine("Мы нашли 5 в массиве,и его порядковый номер:" + n);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
