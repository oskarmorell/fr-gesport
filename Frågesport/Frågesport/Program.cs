using System;

namespace Frågesport
{
    class Program
    {
        public int totalright = 0;
        public string correctanswer = "Hello";
        public string question;
        //Card currentcard;
        static void Main(string[] args)
        {
            //currentcard = new Card();
            Console.WriteLine("Första frågan är" /*+ Database.getquestion();*/);
            string answer = Console.ReadLine();
            //Card.iscorrect(answer);
            Console.WriteLine("Andra frågan är" /*+ Database.getquestion();*/);
            string answer2 = Console.ReadLine();
            //Card.iscorrect(answer2);
            Console.WriteLine("Tredje frågan är" /*+ Database.getquestion();*/);
            string answer3 = Console.ReadLine();
            //Card.iscorrect(answer3);
            Console.ReadKey();
        }
    }
}
