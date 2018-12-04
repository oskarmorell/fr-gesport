using System;
using System.Collections.Generic;
using System.Text;

namespace Frågesport
{
    class Database
    {
        private List<Card> qcards = new List<Card>();
        int x;

        public Database()
        {
            Card myCard0 = new Card("Sveriges huvudstad?", "Stockholm");
            qcards.Add(myCard0);

            Card myCard1 = new Card("Norges huvudstad?", "Oslo");
            qcards.Add(myCard1);

            Card myCard2 = new Card("Danmarks huvudstad?", "Köpenhamn");
            qcards.Add(myCard2);

        }

        public Card GetCard()
        {
            x++;
            Card myCard = qcards[0 + x];
            return myCard;
        }

    }
}
