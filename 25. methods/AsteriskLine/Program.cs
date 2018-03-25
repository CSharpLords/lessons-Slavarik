using System;
namespace AsteriskLine {
	class Program {
		static void Main(string[] args) {
			PrintAsterisks(3);
			Console.ReadLine();
		}
        static void PrintAsterisks(int amount) {
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
	}
}
