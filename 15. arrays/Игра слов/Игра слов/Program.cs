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
            int n = 0;
            int a = 0;
            string tup = null;
            string tul = null;
            string tum = null;
            string[] nouns = {"Тайджик","Ким-Чанын","Узбек","Китаёз","Акулька"};
            string[] adverbs = {"плавно","нервно","снова","моментально","тихооо"};
            string[] verbs = {"бзднул","пукнул","запустил ракеты","нашаманил","загадал"};
            Random rand = new Random();
            while (n < 5)
            {
                a = rand.Next(0, 4);
                tup = nouns[a];
                a = rand.Next(0, 4);
                tul = adverbs[a];
                a = rand.Next(0, 4);
                tum = verbs[a];
                Console.WriteLine("Ваше слово:" + tup + " " + tul + " " + tum);
                n = n + 1; 
            }
            Console.ReadLine();
 
        }
    }
}
