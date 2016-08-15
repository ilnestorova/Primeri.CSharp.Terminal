using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndArrays
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
}
