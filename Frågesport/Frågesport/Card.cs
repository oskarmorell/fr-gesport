using System;
using System.Collections.Generic;
using System.Text;

namespace Frågesport
{
    class Card
    {
        private string question;
        private string answer;
        
        public Card(string fråga, string svar)
        {
            this.question = fråga;
            this.answer = svar;
        }
        public string Getquestion()
        {
            return question; 
        }
        public string Getanswer()
        {
            return answer;
        }
        public bool Iscorrect (string guess)
        {
            if (guess == answer)
            {
                return true;
            }
            if (guess != answer)
            {
                return false;
            }
        }
    }
}
