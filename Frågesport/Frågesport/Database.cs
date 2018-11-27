using System;
using System.Collections.Generic;
using System.Text;

namespace Frågesport
{
    class Database
    {
        private List<Card> qcards = new List<Card>();

        public Database()
        {
            Card myCard0 = new Card("fraga", "svar");
            qcards.Add(myCard0);

            Card myCard1 = new Card("fraga2", "svar2");
            qcards.Add(myCard1);

            Card myCard2 = new Card("fraga3", "svar3");
            qcards.Add(myCard2);

        }

        public Card getCard()
        {
            Card myCard = qcards.RemoveAt(0);
            return myCard;
        }

    }
}
