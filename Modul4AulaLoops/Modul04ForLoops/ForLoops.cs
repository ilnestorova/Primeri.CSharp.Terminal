using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul04ForLoops
{
    class ForLoops
    {
        static void Main(string[] args)

        {

            // string c = "Peter plet plete po tri prata preplita pleti ";
            //c += "Petre pleta podpri Petre pleta padna Petre pleta";
            /*
            string[] masiv = c.Split(' ');
            for(int i=0;i<masiv.Length/2;i++)
            {
                Console.Write(masiv[i*2+1]+" "+masiv[i*2]+" ");
            }
            Console.WriteLine();
            */
            /*
            string c = "1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16";
            string[] a = c.Split(' ');

            string tmp = ""; // Създаваме си временна променлива която
                             // ще ни помогне да подменим един елемент с друг
                             // 'tmp' идва от 'temporary', което значи 'временен'

            var r = new Random(); // Нашият генератор на произволни числа

            var rand = 0;         // Тук ще слагаме произволните числа

            for (int i = 0; i < a.Length; i++)
            { // Цикъл от 0 до 
              // (колкото е дълъг масива 'a')

                rand = r.Next(0, i + 1); // Взимаме произволно число вътре между тези граници
                                      // MinValue The inclusive lower bound of the random 
                                       //MaxValue The exclusive upper bound of the random
                tmp = a[i];           // Запаметяваме какво има в клетката a[i]
                a[i] = a[rand];       // Взимаме дума от клетка a[rand] и я
                                      // слагаме в клетка a[i]
                                      // В този момент ако не пазехме стойността на
                                      // a[i] в 'tmp', щяхме да я загубим

                a[rand] = tmp;        // Но понеже я пазим - ще я сложим в 
                                      // клетката a[rand]
               // Console.WriteLine(rand); for control what is happened
            }

            // След което ще съберем нашият масив в текстов низ, като разделяме
            // думите с разстояния и ще ги покажем на екрана
            Console.WriteLine(string.Join(" ", a));
            */

            /* string[] table = { "John", "George", "Gergana" };
             //antetka na table
             Console.WriteLine("Name");
             Console.WriteLine("==========");
             //body of the table
             for (int i = 0; i < table.Length; i++)
             {
                 Console.WriteLine(table[i]);
             }
             */
            string[,] table2 = { 
            { "Ivan",    "Georgiev",     "12"},
            { "George",  "Ivanov",       "19"},
            { "Maria",   "Georgieva",    "22"},
            { "Ana",     "Gerganova",    "52"},
            { "Gergana",  "Mihailova",    "55"},
            { "Ivanka",  "Strashimirova", "16"},
            { "Drozd",   "Simeonov",      "10"} };
            //antetka na tablicata
            Console.WriteLine("Name".PadRight(15)+"Surname".PadRight(15)+"Age".PadRight(15));//za formatirane na tekst v ""
                                                                                             // Console.WriteLine("{ 0,15} { 1,15} { 2,15}",Name,Surname,Age); tova se izpolzva pri predvaritelno zadadeni promenlivi
            Console.WriteLine("============================================");
            for(int i=0;i<table2.Length/3;i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(table2[i, j].PadRight(15));
                }
                Console.WriteLine();
            }

           
        }

    }
}
