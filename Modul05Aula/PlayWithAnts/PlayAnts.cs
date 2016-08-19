using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithAnts
{
    class Ant
    {

        public double sila, kusmet, izdruzlivost, intelekt, nachalna_izdruzlivost;
        public int nomer;
        public string history;

        public static Random rand = new Random();

        public Ant(int _nomer)
        {
            nomer = _nomer;
            sila = rand.Next(0, 10);
            kusmet = rand.Next(0, 10);
            izdruzlivost = rand.Next(0, 10);
            intelekt = rand.Next(0, 10);
            double koef = 40 / (sila + kusmet + izdruzlivost + intelekt); // Искаме сумарно 4-рите характеристики да са 40точки.
            sila *= koef;
            kusmet *= koef;
            izdruzlivost *= koef;
            intelekt *= koef;
            nachalna_izdruzlivost = izdruzlivost;

        }

        public double Attack(Ant opponent)
        {
            double score = 0;

            izdruzlivost += 3; // Преди всяка атака ще добавяме 3 издръжливост. 
            if (izdruzlivost > nachalna_izdruzlivost) izdruzlivost = nachalna_izdruzlivost; // Ако издръжливостта е над началната, ще я намалим
            if (izdruzlivost < 0) izdruzlivost = 0; // Ако е под нула ще я нулираме
            if (rand.Next(0, 10) < kusmet) score += 2; // Ако има късмет ще добавим 2 точки към атаката

            score += sila / 3; // атаката се увеличава със силата делено на 3
            score *= izdruzlivost / 30; // и се умножава по издръжливостта делена на 30

            if (intelekt > opponent.intelekt) score *= 2; // Ако мравката е по-умна от другата, то умножаваме атаката по 2

            opponent.izdruzlivost -= score * 2; // Намаляваме издръжливостта на опонента спрямо атаката
            return score;
        }

        public string print()
        {
            return "(#" + nomer + " End:" + izdruzlivost.ToString("#0") + " Int:" + intelekt.ToString("#0") 
                + " Lu:" + kusmet.ToString("#0") + " Str:" + sila.ToString("#0") + ")";
        }


    }


    // Главният клас
    class MainClass
    {

        // Главен метод на главния клас се пуска при стартиране на програмата
        public static void Main()
        {
            List<Ant> ants = new List<Ant>();
            List<Ant> winners = new List<Ant>();

            int i;

            for (i = 0; i < 128; i++)
            {
                ants.Add(new Ant(i));
            }

            Console.WriteLine("Game start");
            string history = "";
            Ant atakuvasht, zashtitavasht;

            double score1 = 0, score2 = 0;
            do
            {
                Console.WriteLine("In this tour there are " + ants.Count + " Ants");
                for (i = 0; i < ants.Count; i += 2)
                {

                    // Мравката с няй-голям късмет ще атакува първа
                    if (ants[i].kusmet > ants[i + 1].kusmet)
                    {
                        atakuvasht = ants[i];
                        zashtitavasht = ants[i + 1];
                    }
                    else
                    {
                        atakuvasht = ants[i + 1];
                        zashtitavasht = ants[i];
                    }

                    score1 = atakuvasht.Attack(zashtitavasht);
                    score2 = zashtitavasht.Attack(atakuvasht);

                    history = "\n " + atakuvasht.print() + " attack " + zashtitavasht.print();
                    atakuvasht.history += history;
                    zashtitavasht.history += history;
                    if (score1 > score2)
                    {
                        winners.Add(atakuvasht);
                    }
                    else
                    {
                        winners.Add(zashtitavasht);
                    }
                }

                ants.Clear();
                ants.AddRange(winners);
                winners.Clear();

            } while (ants.Count > 1);

            Console.WriteLine("\nNumber of wining ant is  " + ants[0].nomer);
            Console.WriteLine("Intelecy: " + ants[0].intelekt.ToString("#0.0"));
            Console.WriteLine("Endurance at the end: " + ants[0].izdruzlivost.ToString("#0.0"));
            Console.WriteLine("Endurance at the beggining: " + ants[0].nachalna_izdruzlivost.ToString("#0.0"));
            Console.WriteLine("Luck: " + ants[0].kusmet.ToString("#0.0"));
            Console.WriteLine("Strenght: " + ants[0].sila.ToString("#0.0"));

            Console.WriteLine("\nHistory of ant is :" + ants[0].history + "\n");


        }
    }
}
