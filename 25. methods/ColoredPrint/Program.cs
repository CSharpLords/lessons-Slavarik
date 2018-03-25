using System;

namespace ColoredPrint {
	class Program {
		static void Main(string[] args) {
			// вызов метода PrintColoredText c разными аргументами
			PrintColoredText("70% даунов с читами", ConsoleColor.Red);
			PrintColoredText("5% норм пасанов", ConsoleColor.Yellow);
            PrintColoredText("5% жирные ублюдки (Valve CSGO)", ConsoleColor.DarkMagenta);
            PrintColoredText("5% школьники", ConsoleColor.DarkYellow);
            PrintColoredText("15% Поляки", ConsoleColor.DarkRed);

			Console.ReadLine();
		}

		static void PrintColoredText(string text, ConsoleColor color) {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = color;
            Console.WriteLine(text);

		}
    }
}
