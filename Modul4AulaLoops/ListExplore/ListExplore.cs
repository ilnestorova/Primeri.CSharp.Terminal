using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExplore
{
    class ListExplore
    {
        static void Main(string[] args)
            //List
            
        {
            string userinput = "";
            List<int> mylist = new List<int>();
            //Add to List
            mylist.Add(1);
            mylist.Add(3);
            mylist.Add(5);
            do
            {
                Console.Write("Please enter smtg: ");
                userinput = Console.ReadLine();
                
                //Preview of List
                if (userinput.Contains("show"))
                {
                    Console.Write("List: ");
                    for (int i = 0; i < mylist.Count; i++)
                    {
                        Console.Write(mylist[i]);
                        if (i != mylist.Count - 1) Console.Write(", ");
                    }
                    Console.WriteLine();
                }
                
                //Size of List

            } while (userinput != "exit");
        }
    }
}
