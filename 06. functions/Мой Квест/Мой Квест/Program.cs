using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            Freim("Ты - супергерой. Твоя задача - вызволить принцессу из плена Всемирной Сети, куда она попала, по неосторожности ткнув в рекламный баннер. Выбери действие:");

            Console.WriteLine();
            ShowOption("1. Поиграть в Доту");
            ShowOption("2. Узнать на каком сайте она застряла");
            int answer1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (answer1 == 1)
            {
                Lose("ты просидел в Доте до утра, и принцессу спас другой хакер");
            }
            else if (answer1 == 2)
            {
                Freim("Оказывается, принцессе пришло письмо с рекламой суперстойкой помады, и там был баннер со ссылкой на сайт dontclickme.noob.");
            }
            else
            {
                SchoolBoy();
            }

            Console.WriteLine();
            ShowOption("1. Послушаться совета в адресе сайта и поиграть в Доту");
            ShowOption("2. Перейти на сайт");
            ShowOption("3. Обновить антивирус, а потом перейти на сайт");
            int answer2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (answer2 == 1)
            {
                AnotherHackerHelp(); ;
            }
            else if (answer2 == 2)
            {
                Lose("игрок заразился тем же вирусом, что и принцесса, застрял на том же сайте со сломанным компьютером");
            }
            else if (answer2 == 3)
            {
                ;
                Freim("Игрок встречает противника - Капча-Монстра, который не дает обновить антивирус. Чтобы его победить, нужно решить задачку: сколько будет 2 + 2 * 2?");
            }
            else
            {
                SchoolBoy();
            }

            Console.WriteLine();
            ShowOption("1. А, ну ее, математика для нубов! Пойду в Доту поиграю!");
            ShowOption("2. Проверить исходный код Капча-Монстра");
            ShowOption("3. Ответить монстру: 6");
            int answer3 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (answer3 == 1)
            {
                AnotherHackerHelp();
            }
            else if (answer3 == 2)
            {
                Freim("Игрок вскрывает код Капча-Монстра и видит, что тот печатает черным цветом некоторые символы. Ух ты! Их не видно на черном фоне!");
            }
            else if (answer3 == 3)
            {
                Lose("было бы слишком легко выиграть! На самом деле там невидимые скобки - это и есть супер-способность Капча-Монстра! Задание выглядит как (2 + 2) * 2");
            }
            else
            {
                SchoolBoy();
            }

            Console.WriteLine();
            ShowOption("1. Круто, пойду попробую так в своей программе!");
            ShowOption("2. Ответить монстру: 6");
            ShowOption("3. Заменить цвет всех черных символов на белый и перезагрузить Капчу-Монстра");
            int answer4 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (answer4 == 1)
            {
                Lose("принцесса заблудилась во Всемирной Сети, пока герой ковырялся не там, где надо");
            }
            else if (answer4 == 2)
            {
                AnotherHackerHelp();
            }
            else if (answer4 == 3)
            {
                Freim("Капча-Монстра хрипит консольными командами, догружается, наконец, до конца и выдает: сколько будет (2 + 2) * 2?");
            }
            else
            {
                SchoolBoy();
            }

            Console.WriteLine();
            ShowOption("1. Ответить монстру: 8");
            ShowOption("2. Герою лень считать, и он идет в Доту");
            int answer5 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (answer5 == 1)
            {
                Freim("Капча-Монстр обиженно сопит \"Как ты догадался? Я же спрятал скобки!\", отступает и позволяет обновить антивирус. Теперь герой защищен, и может перейти на сайт! Едва он делает это, как получает сообщение антивируса: Замечена и заблокирована вредоносная программа: WinLock 1.0. Файл-лекарство можно найти здесь: C:Antiviruscure.exe.");
            }
            else if (answer5 == 2)
            {
                AnotherHackerHelp();
            }
            else
            {
                SchoolBoy();
            }

            Console.WriteLine();
            ShowOption("1.Отправить лекарство принцессе по почте и пойти в Доту");
            ShowOption("2.Записать лекарство на флешку и пойти к принцессе домой");
            int answer6 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (answer6 == 1)
            {
                Lose("у нее сломался компьютер, она не может получить твой файл! Принцессу спасает другой хакер");
            }
            else if (answer6 == 2)
            {
                Freim("Ура!!! Победа! Ты успешно справился со всеми испытаниями и спас принцессу!");
            }
            else
            {
                SchoolBoy();
            }
        }
        static void SchoolBoy()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Введен невалидный вариант! Конец игры");
            Console.ReadLine();
            Environment.Exit(0);
        }
        static void AnotherHackerHelp()
        {
            Console.WriteLine("Конец игры! Проигрыш - другой хакер спас принцессу");
            Console.ReadLine();
            Environment.Exit(0);
        }
        static void ShowOption(string option)
        {
            Thread.Sleep(200);
            Console.WriteLine(option);
        }
        static void Freim(string freim)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(freim);
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        static void Lose(string lose)
        {
            Console.WriteLine("Конец игры! Проигрыш - " + lose);
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
