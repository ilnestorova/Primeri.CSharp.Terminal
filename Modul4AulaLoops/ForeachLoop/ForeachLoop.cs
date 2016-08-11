using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachLoop
{
    class ForeachLoop
    {
        static void Main(string[] args)
        // има за цел да извади срички от най-популярните брандове на планетата. 
        //След това ще се опита да създаде нови брандове, като комбинира тези срички.
        {
            List<string> brands = new List<string>() { 
                //Това е краткия начин по 
                //който да дефинираме и запълним лист
"sony","cocacola","pepsi","ibm","mentos","panasonic","fanta",
"sprite","apple","microsoft","google","mcdonalds","samsung",
"facebook","disney","pixar","amazon"}; //Лист с популярни брандове

            List<string> srichki = new List<string>(); 
            // Ще извадим срички от брандовете и ще ги сложим тук
            int i = 0;

            List<string> glasni = new List<string>() { "a", "e", "i", "o", "u", "y" };
            // Тук ще държим гласните

            foreach (string brand in brands)
            {

                for (i = 0; i < brand.Length - 1; i++)
                {
                    if (glasni.Contains(brand[i].ToString()) ||  
                        // Ако сричката няма гласна, то ще я отхвърлим
                        glasni.Contains(brand[i + 1].ToString()))
                        srichki.Add("" + brand[i] + brand[i + 1]); 
                    // Всички останали срички ги запомняме
                }

            }

            Console.WriteLine("Открити срички: " + string.Join(" ", srichki) + "\n"); 
            // Ще покажем сричките на екрана

            var r = new Random();

            string my_brand = "";  
            // Тук ще пишем произволни срички
            Console.WriteLine("Нови брандове:");
            for (int k = 0; k < 20; k++)
            { // Искаме да създадем 20 нови бранда
                my_brand = ""; // Всеки път трябва да започваме от нищо
                for (int j = 0; j < r.Next(2, 10); j++)
                { // Искаме новия бранд да е с от 2 до 10 срички

                    my_brand += srichki[r.Next(0, srichki.Count - 1)];
                    // Добравяме произволна сричка към новия бранд
                }
                Console.WriteLine(my_brand); 
                // Показваме новия бранд на екрана
            }

        }
    }
}
