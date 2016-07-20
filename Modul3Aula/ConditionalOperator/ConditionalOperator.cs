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

            try
            {
                Console.Write("Element "+ui.ToString()+" of the array is: ");
                Console.WriteLine(i[ui-1]);
            }
            catch
            {
                Console.WriteLine("Invalid index.Please try with number between 1 and 3");
            }
            // Izpolzvane na  uslovno prisvoqvane
            /*
            ui = ui <= i.Length ? ui : 3;
            ui = ui >0 ? ui : 1;
            if(check1)
            {
                Console.WriteLine(i[ui-1]);
            }
            */

            // Izpolsvane na switch-case
         /*
            switch(ui)
            {
                case 1: Console.Write("The first element of the array is: ");
                    Console.WriteLine(i[ui-1]);break;
                case 2:
                    Console.Write("The second element of the array is: ");
                    Console.WriteLine(i[ui - 1]); break;
                case 3:
                    Console.Write("The third element of the array is: ");
                    Console.WriteLine(i[ui - 1]); break;
                default:
                    Console.Write("There are not such element in the array.Please, try with number between 1 and 3 ");
                    Console.WriteLine(); break;
            }
            */
        }
    }
}
