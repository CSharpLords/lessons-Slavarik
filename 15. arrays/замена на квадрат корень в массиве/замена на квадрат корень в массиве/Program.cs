using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace замена_на_квадрат_корень_в_массиве
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = {1.2 , 10.5 , 11.6 , 17.5 };
            for (int n = 0; n < array.Length; n++)
            {
                if (array[n] > 10)
                {
                    double Square = Math.Sqrt(array[n]);
                    Console.WriteLine("Корень из " + array[n] + "-равен:" + Square);
                    Console.WriteLine();
                    array[n] = Square;
                    
                }
            }
            foreach (double element in array)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }
    }
}
