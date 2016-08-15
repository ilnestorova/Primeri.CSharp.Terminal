using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class OutRef
    {
        static void Main(string[] args)
        {
           
            string usercommand = "";
            do
            {
                Console.Write("Enter a command: ");
                usercommand = Console.ReadLine();
                if (usercommand.Contains("cmd01")) cmd01(usercommand);
                // if (usercommand.Contains("cmd02")) Console.WriteLine(cmd02(usercommand));
                if (usercommand.Contains("cmd03"))
                {
                    double a;
                    if (cmd03(usercommand, out a))
                    {
                        Console.WriteLine("a*a=" + a.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Uncorrect input");
                    }
                }
               /* if (usercommand.Contains("cmd04"))
                {
                    double t = 5;
                    double c = -2;
                    if(cmd04(ref t))
                    {
                        Console.WriteLine(t);
                    }
                    if(cmd04(ref c))
                    {
                        Console.WriteLine(c);
                    }
                }*/
            }
            while (usercommand != "exit");
        }
        public static void cmd01(string input) //Test 5  5^2
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

        //cmd02 is not working
        /* public static int cmd02 (string input)
         {
             int temp = 0;
             if (int.TryParse(input.Split(' ')[1], out temp))
             {
                 temp = temp * temp * temp;
                 return temp;

             }

         }*/
        public static bool cmd03(string input, out double i)
        {
            try
            {
                string p = input.Split(' ')[1];
                double pp = 0;
                if (double.TryParse(p, out pp))
                {
                    i = pp * pp;
                    return true;
                }
            }
            catch { }
            i = 0;
            return false;
        }
            
    }
        //cmd04 is not working
       /* public static bool cmd04(ref double i)
        {
            double temp = 0;
            i = i * i;
            return (temp > 0);
        }*/
}

