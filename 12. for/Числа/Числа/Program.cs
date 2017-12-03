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
            for (int number = 10; number < 26; number = number + 1)
            {                                        
                Console.WriteLine(number + " " + number + "." + 4);
            }
            Console.ReadLine();
        }
    }
}
