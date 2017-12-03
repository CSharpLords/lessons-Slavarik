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
            int b = 7;
            for (int account = 1; account < 11; account = account + 1)
            {                
                int c = account * b;
                Console.WriteLine("Умножение: " + account  + " * " + b  + " = " + c);
            }
            Console.ReadLine();
        }
    }
}
