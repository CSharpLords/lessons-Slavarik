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
            int account = 1;
            int b = 7;
            for (int a = 1; a < 11; a = a + 1)
            {
                
                int c = a * b;
                Console.WriteLine(account + ".Умножение:" + c);
                account = account + 1;
            }
            Console.ReadLine();
        }
    }
}
