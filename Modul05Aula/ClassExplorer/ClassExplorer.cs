using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExplorer
{
    /* public class person
     {
         public string simplestring = "Tekst";
         public person()
             {
             simplestring = "New tekst";
             }
     }
     class ClassExplorer
     {
         static void Main(string[] args)
         {
             // class declaration 
             person Nperson = new person();
             // class laccess
             Console.WriteLine(Nperson.simplestring);
         }*/
    // Създаваме клас "човек"
    public class chovek
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

    }

    // Главният клас
    class MainClass
    {

        // Главен метод на главния клас се пуска при стартиране на програмата
        public static void Main()
        {

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
    }
}

