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
            Console.WriteLine("Василий,загадай слово.");
            string word = Console.ReadLine();
            word = word.ToLower();
            int True = 0;
            int Number = 0;            
            int Try = 5;
            while (Try > 0) {
                Console.WriteLine("Валера, вводи символы по порядку");
                char letter = char.Parse(Console.ReadLine().ToLower());
                char Char = word[Number];
                if (letter != Char)
                {
                    Console.WriteLine("Буква не верна!");
                    Try = Try - 1;
                    Console.WriteLine("Осталось:" + Try + " попыток(ки)");
                }
                else if (letter == Char) {
                    Console.WriteLine("Молодец,Буква верна!!!");
                    Number = Number + 1;
                    True = True + 1;
                    if (True == word.Length) {
                        Console.WriteLine();
                        Console.WriteLine("Молодец,ты угадал всё слово!!!");
                        break;
                    }
                }

            }
            Console.ReadLine();
        }
    }
}
