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
            double[] massiv = { 32,123,512,123,123,43,32 };
            int n = 0;
            int a = massiv.Length - 1;
            while(n < massiv.Length){
                double c = massiv[n] / massiv[0];
                Console.WriteLine(c);
                n = n + 1;
            }
            Console.ReadLine();
        }
    }
}
