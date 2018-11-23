using System;

namespace Frågesport
{
    class Program
    {
        int totalright = 0;
        string correctanswer;
        string question;
        Card currentcard;
        static void Main(string[] args)
        {
            Database.getquestion();  
            Console.ReadKey();
        }
    }
}
