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
            Console.WriteLine("Валерка,что тебе надобно?");
            Console.WriteLine("-носки");
            Console.WriteLine("-портфель");
            Console.WriteLine("-тапочки");
            Console.WriteLine("-Xbox");
            Console.WriteLine("-телефон");
            Console.WriteLine("-записка с паролем от Dota2.");
            string answer = Console.ReadLine().ToLower();
            if (answer == "носки") {
                Console.WriteLine("Они под кроватью.");
            }
            else if (answer == "портфель") {
                Console.WriteLine("Около шкафа.");
            }
            else if (answer == "тапочки") {
                Console.WriteLine("Рядом со стулом.");
            }
            else if (answer == "Xbox") {
                Console.WriteLine("на полке,которая окло стола.");
            }
            else if (answer == "телефон") {
                Console.WriteLine("на стуле.");
            }
            else if (answer == "записка с паролем от dota2")
            {
                Console.WriteLine("на столе.");
            }
            else
            {
                Console.WriteLine("Такую вещь я не знаю!");
            }
            Console.ReadLine();
        }
    }
}
