using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExplorer
{
   /* public class person
    {
        public string simplestring = "T";
        private string hiddenStr = "";
        public string user = "";
        public person(string IND)
        {
            if (IND == "Pass1") hiddenStr = "User1";
            if (IND == "Pass2") hiddenStr = "User2";
            user = hiddenStr;
            if (hiddenStr.Length > 0) simplestring = "Wellcome " + user + " !";
            else simplestring = "Access denied";
        }
    }
    class ClassExplorer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the password");
            string Nuser = Console.ReadLine();
            // class declaration 
            person Nperson = new person(Nuser);
            // class access
            Console.WriteLine(Nperson.simplestring);
            Console.WriteLine(Nperson.user+", well done"+" !");

        }
*/

        public class person
        {
            private string simplestring = "T";
            private string hiddenStr = "";
            private string user = "";
            public person(string IND)
            {
            getUser(IND);
            setWellcomeText();
            }
        private void getUser(string IND)
        {
            if (IND == "Pass1") hiddenStr = "User1";
            if (IND == "Pass2") hiddenStr = "User2";
            user = hiddenStr;
        }
        private void setWellcomeText()
        {
            if (hiddenStr.Length > 0) simplestring = "Wellcome " + user + " !";
            else simplestring = "Access denied";
        }
        public string getWellcomeMessage()
        {
            return simplestring;
        }
        }
        class ClassExplorer
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the password");
                string Nuser = Console.ReadLine();
                // class declaration 
                person Nperson = new person(Nuser);
                // class access
                Console.WriteLine(Nperson.getWellcomeMessage());
            }



            // Създаваме клас "човек"
            /* public class chovek
             {

                 // Всеки човек ще има "ime" и "godini". Това ще са свойства (properties)
                 //на всеки обект от класа chovek.
                 public string ime;
                 public int godini;

                 // Конструктора на нашия клас. Той приема параметри име, години и ги
                 // Поставя в свойствата на обекта достъпни от целия клас
                 public chovek(string _ime, int _godini)
                 {
                     // _ime и _godini са локални променливи за този метод. Когато той свърши
                     // те ще бъдат изтрити. За това ще ги запишем в
                     //променливите / свойствата ime и godini
                     // който са постоянни и достъпни от всички методи.

                     ime = _ime;
                     godini = _godini;
                 }

                 public void Print()
                 {
                     Console.WriteLine("My name is  " + ime + "  and I am " + godini + " years old");
                 }

             }*/



            /* public class Student
             {
                 public string ime = "";
                 public double ocenka = 0.00;
                 public Student(string Nime, double Nocenka)
                 {
                     ime = Nime;
                     ocenka = Nocenka;
                 }
                 public void PrintStudent()
                 {
                     Console.WriteLine("Student" + ime + " has assessment " + ocenka);
                 }
             }
             // Главният клас
             class MainClass
             {

                 // Главен метод на главния клас се пуска при стартиране на програмата
                 public static void Main()
                 {

                     List<Student> Grupa = new List<Student>();
                     Grupa.Add(new Student("Ivan", 4.2));
                     Grupa.Add(new Student("Petar", 3.6));
                     Grupa.Add(new Student("Anna", 5.5));
                     foreach (Student X in Grupa)
                     {
                         X.PrintStudent();
                     }
                     */

            /*
              // По същия начин по който дефинираме 'int' и 'string', 
              // ще дефинираме променливите ivan,dragan, georgi 
              // и ще ги инициализираме чрез конструкторите им
              chovek ivan = new chovek("Ivan", 23);

              chovek dragan = new chovek("Dragan", 33);

              chovek georgi = new chovek("Georgi", 45);

              ivan.Print();
              dragan.Print();
              georgi.Print();
          }
          */
        }
    }


