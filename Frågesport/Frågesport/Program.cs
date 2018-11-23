using System;

namespace Frågesport
{
    class Program
    {
        public int totalright = 0;
        public string correctanswer;
        public string question;
        //Card currentcard;
        static void Main(string[] args)
        {
            //currentcard = Card.getquestion();
            Console.WriteLine("Första frågan är" /*+ currentcard*/);
            string answer = Console.ReadLine();
            //Card.iscorrect(answer);

            //currentcard = Card.getquestion();
            Console.WriteLine("Andra frågan är" /*+ currentcard*/);
            string answer2 = Console.ReadLine();
            //Card.iscorrect(answer2);

            //currentcard = Card.getquestion();
            Console.WriteLine("Tredje frågan är" /*+ currentcard*/);
            string answer3 = Console.ReadLine();
            //Card.iscorrect(answer3);
            Console.ReadKey();
        }
    }
}
