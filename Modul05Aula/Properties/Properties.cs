using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Properties
    {
        public class person
        {
            private string userName = "";
            private string userPass = "";
            public string UserName
            {
                get { return userName; }
            }
            public string UserPass
            {
                get { return userPass; }
            }
            private string userID = "";
            private string userFName="";
            private string userLName = "";
            public string UserID
            {
                get { return userID; }
                set { userID = value; }

            }
            public string UserFName
            {
                get { return userFName; }
                set { userFName = value; }

            }
            public string UserLName
            {
                get { return userLName; }
                set { userLName = value; }

            }
            public person(string User, string Pass)
            {
                CheckUser(User, Pass);
            }
            private bool CheckUser (string User, string Pass)
            {
                if (User == "Astro" && Pass == "Astro07")
                {
                    userName = "User";
                    userPass = "Pass";
                    // Popalvane na properties
                    userID = "ID: 611109XXXX";
                    userFName = "Iliana";
                    userLName = "Nestorova";
                    return true;
                }
                return false;
            }

        }
        static void Main(string[] args)
        {
            Console.Write("Enter user: ");
            string user = Console.ReadLine();
            Console.Write("Enter passwort: ");
            string pass = Console.ReadLine();
            person Person = new person(user, pass);
            Console.WriteLine(Person.UserFName+" "+Person.UserLName);

        }
    }
}
