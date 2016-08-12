using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string usercommand = "";
            do
            {
                Console.Write("Enter a command: ");
                usercommand = Console.ReadLine();
                if (usercommand.Contains("test1")) test1(usercommand);
                if (usercommand.Contains("test2")) Console.WriteLine(test2());
            }
            while (usercommand != "exit");
        }
            public static void test1(string input) //Test 5  5^2
        {
            try
            {
                double temp = 0;
                if (double.TryParse(input.Split(' ')[1], out temp))
                {
                    Console.WriteLine("the rezult of " + temp.ToString() + "^2" + " is: "
                        + (temp * temp).ToString());
                }
            }
            catch { }
        }
       public static int test2(string input)
        {
            int temp = 0;
            if (int.TryParse(input.Split(' ')[1], out temp))
            {
                temp = temp * temp * temp;
                return temp;
 
            }
    }
}
