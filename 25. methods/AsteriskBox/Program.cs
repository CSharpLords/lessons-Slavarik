using System;

namespace AsteriskBox {
	class Program {
		static void Main(string[] args) {
			PrintAsteriskBox(2, 2);
			Console.ReadLine();
		}
        static void PrintAsterisks(int amount)
        {
            string star = "";
            for (int n = 0; n < amount; n++)
            {
                if (n < amount)
                {
                    star = star + "*";
                }
            }
            Console.WriteLine(star);
        }

        static void PrintAsteriskBox(int a, int b)
        {
            for (int n = 0; n < b; n++)
            {
                PrintAsterisks(a);
            }
        }
	}
}
