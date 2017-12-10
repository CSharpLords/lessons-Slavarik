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
            Console.WriteLine("Василий,загадай число!");
            int Number = int.Parse(Console.ReadLine());
            if (Number > 999)
            {
                Console.WriteLine("Нельзя больше: 999!!!");
                Console.ReadLine();
            }
            else if (Number <= 999)
            {
                int Try = 1;
                Console.WriteLine("Валерка,угадай число!");
                while (true)
                {
                    int Answer = int.Parse(Console.ReadLine());
                    if (Answer < Number)
                    {
                        Console.WriteLine("Ваше число меньше загаданого.");
                        Console.WriteLine("Попробуй ещё раз");
                        Try = Try + 1;
                    }
                    else if (Answer > Number)
                    {
                        Console.WriteLine("Ваше число больше загаданого.");
                        Console.WriteLine("Попробуй ещё раз");
                        Try = Try + 1;
                    }
                    else if (Answer == Number)
                    {
                        Console.WriteLine("Поздравляю,Валерка,ты угадал с попытки №" + Try);
                    }
                    
                }
            }
            Console.ReadLine();
        }
    }
}
