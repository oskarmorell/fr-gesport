using System;
using System.Collections.Generic;
using System.Text;

namespace Frågesport
{
    class Card
    {
        private string question;
        private string answer;
        Card card;
        Database minDatabas = new Database();

        public Card(string fråga, string svar)
        {
            this.question = fråga;
            this.answer = svar;
        }
        public string Getquestion()
        {
            card = minDatabas.GetCard();
            return card.question; 
        }
        public string Getanswer()
        {
            return card.answer;
        }
        public bool Iscorrect (string guess)
        {
            if (guess == answer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
