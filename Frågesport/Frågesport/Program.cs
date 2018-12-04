using System;

namespace Frågesport
{
    class Program
    {
        public int totalright = 0;
        public string correctanswer;
        public string question;
        string currentcard = new Card();
        static void Main(string[] args)
        {
            currentcard.Getquestion();
            Console.WriteLine("Första frågan är" /*+ currentcard*/);
            string answer0 = Console.ReadLine();
            currentcard.iscorrect(answer0);

            currentcard.Getquestion();
            Console.WriteLine("Andra frågan är" /*+ currentcard*/);
            string answer1 = Console.ReadLine();
            currentcard.iscorrect(answer1);

            currentcard.Getquestion();
            Console.WriteLine("Tredje frågan är" /*+ currentcard*/);
            string answer2 = Console.ReadLine();
            currentcard.iscorrect(answer2);
            Console.ReadKey();
        }
    }
}
