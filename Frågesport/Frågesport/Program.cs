using System;

namespace Frågesport
{
    class Program
    {
        public int totalright = 0;
        public string correctanswer;
        public string question;
        static void Main(string[] args)
        {
            Database minDatabas = new Database();
            Card currentcard = minDatabas.GetCard();
            Console.WriteLine("Vilken stad är " + currentcard.Getquestion());
            string answer0 = Console.ReadLine();
            currentcard.Iscorrect(answer0);

            Console.WriteLine("Vilken stad är " + currentcard.Getquestion());
            string answer1 = Console.ReadLine();
            currentcard.Iscorrect(answer1);

            Console.WriteLine("Vilken stad är " + currentcard.Getquestion());
            string answer2 = Console.ReadLine();
            currentcard.Iscorrect(answer2);
            Console.ReadKey();
        }
    }
}
