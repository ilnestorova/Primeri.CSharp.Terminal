using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WlileDoWhileLoops
{
    class WhileDoWhileLoops
    {
        static void Main(string[] args)
        {
            /*
            int i = 0;
            while (i <=8)
            {
                i += 2;
                Console.Write(i + " ");
                if (i < 10)
                {
                    i -= 1;
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            i = 0;
            do
            {
                i += 2;
                Console.Write(i + " ");
                if (i < 10)
                {
                    i -= 1;
                    Console.Write(i + " ");
                }
            }
            while (i <= 8);
            */
            string[,] table2 = {
            { "Ivan",    "Georgiev",     "12"},
            { "George",  "Ivanov",       "19"},
            { "Maria",   "Georgieva",    "22"},
            { "Ana",     "Gerganova",    "52"},
            { "Gergana",  "Mihailova",    "55"},
            { "Ivanka",  "Strashimirova", "16"},
            { "Drozd",   "Simeonov",      "10"} };
            
            Console.WriteLine("Name".PadRight(15) + "Surname".PadRight(15) + "Age".PadRight(15));//za formatirane na tekst v ""
                                                                                                 // Console.WriteLine("{ 0,15} { 1,15} { 2,15}",Name,Surname,Age); tova se izpolzva pri predvaritelno zadadeni promenlivi
            Console.WriteLine("============================================");
            int i = 0;
            /* while(i<table2.Length/3)
             {
                 Console.WriteLine(table2[i,0].PadRight(15) +
                                 table2[i,1].PadRight(15) + 
                                 table2[i,2].PadRight(15));
                 i++;
                                                                                                      // Console.WriteLine("{ 0,15} { 1,15} { 2,15}",Name,Surname,Age); tova se izpolzva pri predvaritelno zadadeni promenlivi
             }
             */
            do
            {
                Console.WriteLine(table2[i, 0].PadRight(15) +
                                                 table2[i, 1].PadRight(15) +
                                                 table2[i, 2].PadRight(15));
                i++;

            } while (i < table2.Length / 3);
        }

    }
}
