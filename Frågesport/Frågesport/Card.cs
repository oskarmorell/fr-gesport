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
        public string getquestion()
        {
            return question; 
        }
        public string getanswer()
        {
            return answer;
        }
        public bool iscorrect (string guess)
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
