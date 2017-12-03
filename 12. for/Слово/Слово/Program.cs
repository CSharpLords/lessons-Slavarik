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
            Console.WriteLine("Введите ваше,твою мамашу,слово");
            string word = Console.ReadLine();
            word = word.ToLower();
            int a = word.Length - 1;
            if (word[0] == word[a])
            {
                Console.WriteLine("Совпадает.Ты просто Молодец!!!");
            }
            else
            {
                Console.WriteLine("Несовпадает.Просто кусок тебя.Вот...");
            }
            Console.ReadLine();
        }
    }
}
