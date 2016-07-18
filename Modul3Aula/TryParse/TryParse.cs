using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    class TryParse
    {
        static void Main(string[] args)
        {
            int[] i = new[] { 4, 3, 2 };
            Console.WriteLine("Enter tne integer number");
            int ui = 0; //Convert.ToInt32(Console.ReadLine());
            string input = Console.ReadLine();
            bool check0 = int.TryParse(input, out ui);
            bool check1 = ui <= i.Length;
            bool check2 = ui <0;

            if (check0 && check1 && check2)
            {
                Console.WriteLine(i[ui - 1]);
            }
            else
            {
                if (!check2)
                {
                    Console.WriteLine("Unvalid index");
                }
                if (!check1)
                {
                    Console.WriteLine("The index is bigger than the lenght of the array");
                }
                if (!check0)
                {
                    Console.WriteLine("The index must be integer  number");
                }
            }
        }
    }
}