using System;

namespace CalcPower {
	class Program {
		static void Main(string[] args) {
			Console.Write("Введите число: ");
			int n = int.Parse(Console.ReadLine());
			Console.Write("Введите степень: ");
			int e = int.Parse(Console.ReadLine());

			Console.WriteLine(n + "^" + e + "=" + Power(n, e));
			Console.ReadLine();
		}

		static int Power(int number, int exponent) {
            for(int n = 0; n < exponent; n++)
            {
                int result = number exponent;
			    return result;
            }
		}
	}
}
