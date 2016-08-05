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
           /* 
            string userinput = "";
            List<int> mylist = new List<int>();
            //Add to the List another values
            // add <int>
            mylist.Add(1);
            mylist.Add(3);
            mylist.Add(5);
            do
            {
                Console.Write("Please enter smtg: ");
                userinput = Console.ReadLine();
                if(userinput.ToLower().Contains("add"))
                {
                    try
                    {
                        int myadd = 0;
                        if (int.TryParse(userinput.Split(' ')[1], out myadd))
                            {
                            mylist.Add(myadd);
                        }
                        Console.WriteLine();
                    }
                
                    catch {
                        Console.WriteLine("Please anter one interval between add and the integer");
                    }
                }
                
                //Preview of List
                if (userinput.ToLower().Contains("show"))
                {
                    Console.Write("List: ");
                    for (int i = 0; i < mylist.Count; i++)
                    {
                        Console.Write(mylist[i]);
                        if (i != mylist.Count - 1) Console.Write(", ");
                    }
                    Console.WriteLine("\n");
                }
                if(userinput.ToLower().Contains("size"))
                {
                    Console.WriteLine("The size of the mylist is: "+mylist.Count.ToString()+"\n");
                }
                //Size of List

            } while (userinput != "exit");
           */ 
           List<string> z = new List<string>();
            z.Add("apple");
            z.Add("pear");
            z.Add("marmalade");
            z.Add("grapes");
            /*int i = z.IndexOf("marmalade");
            z.RemoveAt(i);
            foreach(string x in z)
            {
                Console.WriteLine(x);
            }
            */
            z.Add("apricot");
            z.Add("oringe");
            z.Add("tree");
            z.Sort();
            Console.WriteLine(string.Join(",",z));
            z.Reverse();
            Console.WriteLine(string.Join(",", z));

        }
    }
}
