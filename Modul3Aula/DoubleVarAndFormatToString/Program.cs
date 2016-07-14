using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleVarAndFormatToString
{

    static class Program
    {
                static void Main()
        {
          
            double a = 0, b = 0;
            a = 1.345;
            string d = "1.687";
            Console.WriteLine(a + b);

            Console.WriteLine(" Enter value of a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Enter value of b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("a/b=" + (a / b).ToString("#0.00 m3"));

        }
    }
}
