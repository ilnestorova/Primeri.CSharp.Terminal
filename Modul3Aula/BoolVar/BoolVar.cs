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
            Console.WriteLine( check1);
            Console.WriteLine(check2);
            Console.WriteLine(i[ui-1]);

        }
    }
}
