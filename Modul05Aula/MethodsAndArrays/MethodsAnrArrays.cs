using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace MethodsAndArrays
{
    class MethodsAnrArrays
    {
        static void Main(string[] args)
        {
            string usercommand = "";
            do
            {
                Console.Write("Enter a number: ");
                usercommand = Console.ReadLine();
            
            if (usercommand.Contains("cmd"))
            {
                Console.WriteLine("the number of even numbers are: "+cmd(usercommand).Length);
            }
            } while (usercommand != "exit");
        }
        public static string[] cmd(string input)
        {
            try
            {
                int border = 0;
                string temp = "";
                if(int.TryParse(input.Split(' ')[1], out border))
                {
                    for(int i=1; i<=border; i++)
                    {
                        if (i % 2 == 0)
                        {
                            temp += i;
                            if (i < border - 1)
                            {
                                temp += ",";
                            }
                        }
                       
                    }
                    Console.WriteLine(temp);//proba
                }
                return temp.Split(',');
            }
            catch { }
            return new string[1] { "0" };
               
        }
    }
}*/

namespace TestovaPrograma
{

    class MainClass
    {

        static Random _random = new Random();
        // (1) Дефинираме и инициализираме променливата _random с генератор
        // на произволни числа. Така може да го ползваме от всички методи.

        public static void Main(string[] args)
        {
            int[] arint = { 1, 2, 3, 4, 5, 6 };
            string[] arstr = { "first", "second", "third", "fourth","fifth","sixth" };

            Shuffle(arint); // (3) Не използваме ref, но метода
                         // пак сменя стойността на ar

            Console.WriteLine(string.Join(" ", arint));

            Shuffle(arstr);
            Console.WriteLine(string.Join(" ", arstr));
        }


        // Метода за размешване 'shuffle'
        // (2) Забележете как дефинираме метода. Ще свърши същата работа
        // както "ref", но няма да има значение дали му подаваме масив от
        // цели числа, масив от текстови низове или друг вид масив.

        static void Shuffle<T>(T[] myar)
        {
            /*int n = myar.Length;
            for (int i = 0; i < n; i++)
            {
                // Алгоритъм за размешване 'Fisher-Yates'
                int r = i + (int)(_random.NextDouble() * (n - i));
                T t = myar[r];
                myar[r] = myar[i];
                myar[i] = t;*/
                for(int i=myar.Length-1;i>0;i--)
            {
                int index = _random.Next(i);
                T t = myar[index];
                myar[index] = myar[i];
                myar[i] = t;
                
            }
            }
        }
    }

