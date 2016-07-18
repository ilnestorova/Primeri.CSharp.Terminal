using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolVar
{
    class BoolVar
    {
        
        static void Main(string[] args)
        {
            //bool b = true;
            //bool test = 5 > 10;
            int[] i = new[] { 4, 3, 2 };
            Console.WriteLine("Enter tne integer number");
            int ui = Convert.ToInt32(Console.ReadLine());
            bool check1 = ui <= i.Length;
            bool check2 = ui < 0;
            //Console.WriteLine( check1);
            //Console.WriteLine(check2);
            //Console.WriteLine(i[ui-1]);
            //bool exp1 = check1 && check2; //Logical "and"
            //bool exp2 = check1 || check2; //Logical "or"
            //bool exp3 = !check1; //Logical "not"

            //Console.WriteLine("Logical AND of "+check1.ToString()+" and "+check2.ToString()
            //   +" is : " +exp1.ToString());
            //Console.WriteLine("Logical OR of "+check1.ToString()+" and "+check2.ToString()
            //   +" is : "+exp2.ToString());
            //Console.WriteLine("Logical Negation of "+check1.ToString()+" is : "
            //   +exp3.ToString());
            if (ui <= i.Length&&ui>0)
            {
                Console.WriteLine(i[ui-1]);
            }
            else
            {
                if(ui<0)
                {
                    Console.WriteLine("Unvalid index");
                }
                if(ui>i.Length)
                {
                    Console.WriteLine("The index is bigger than the lenght of the array");
                }
                
            }
        }
    }
}
