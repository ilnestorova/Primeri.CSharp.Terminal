using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeriMethodsRefOut
{
    class PrimeriMethodsRefOut
    {
        static void Main(string[] args)
        {
            int my;
            bool chetno;
            chetno = proba(2, 5, out my);
            Console.WriteLine("The sum of 2 and 5 is:" + my + ((chetno) ? "chetno" : "nechetno"));
      


        int x = 0;

proba1(ref x);
        Console.WriteLine("Variable:"+x);
proba1(ref x);
        Console.WriteLine("Variable:"+x);
proba1(ref x);
        Console.WriteLine("Variable:"+x);
    }
    public static void proba1(ref int a)
    {
        a = a + 5;
    }
    

    public static bool proba(int a, int b, out int c)
        {
            c = a + b;
            if (c % c == 0) return true;
            else return false;
        }
    }
    
}
