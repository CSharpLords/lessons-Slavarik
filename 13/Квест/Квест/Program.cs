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
            Console.WriteLine("К - Компьютер");
            Console.WriteLine("П - пользователь");
            Console.WriteLine("К: У тебя есть компьютер?");
            string answer = Console.ReadLine().ToLower();
            if (answer == "нет")
            {
                Console.WriteLine("Ну ок, тогда нам не о чем говорить");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (answer == "да")
            {
                Console.WriteLine("К: Сколько часов в неделю ты проводишь за ним?");
                int answer1 = int.Parse(Console.ReadLine());
                if (answer1 <= 14)
                {
                    Console.WriteLine("К: А большую часть этого времени ты работаешь или отдыхаешь?");
                    string answer2 = Console.ReadLine().ToLower();
                    if (answer2 == "работаю")
                    {
                        Console.WriteLine("Ты и отдохнуть не забывай))");
                    }
                    else if (answer2 == "отдыхаю")
                    {
                        Console.WriteLine("К: Хорошо, что ты знаешь меру!");
                    }
                }
                else if (answer1 > 14)
                {
                    Console.WriteLine("К: А большую часть этого времени ты работаешь или отдыхаешь?");
                    string answer4 = Console.ReadLine().ToLower();
                    if (answer4 == "работаю")
                    {

                        Console.WriteLine("К:Пожалей себя!");
                    }

                    else if (answer4 == "отдыхаю")
                    {
                        Console.WriteLine("К: Не порть своё здоровье!!!!");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
