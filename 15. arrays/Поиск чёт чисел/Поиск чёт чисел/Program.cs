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
            int[] array = {1,2,3,4,5,6};
            for (int n = 0; n < array.Length; n++)
            {
                int Rest = array[n] % 2;
                if (Rest == 0)
                {
                    Console.WriteLine("Чёт число найдено и его порядковый номер:" + n);
                }
            }
            Console.ReadLine();
        }
    }
}
