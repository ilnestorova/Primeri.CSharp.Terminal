using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperator
{
    class ConditionalOperator
    {
        static void Main(string[] args)
        {
            int[] i = new[] { 4, 3, 2 };
            Console.WriteLine("Enter tne integer number");
            int ui = 0; 
           
            string input = Console.ReadLine();
            bool check1 = int.TryParse(input, out ui);
            ui = ui <= i.Length ? ui : 3;
            ui = ui >0 ? ui : 1;
            if(check1)
            {
                Console.WriteLine(i[ui-1]);
            }
        }
    }
}
