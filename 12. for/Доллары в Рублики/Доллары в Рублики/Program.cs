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
            for (int dollar = 1; dollar < 21; dollar = dollar + 1)
            {
                int Perevod = 60;
                int Rub = dollar * Perevod;
                Console.WriteLine("Перевод в рубли:" + Rub);
            }
            Console.ReadLine();
        }
    }
}
