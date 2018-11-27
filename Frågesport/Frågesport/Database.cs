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
        }

        public string getquestion(Card qcard)
        {
            qcards.Add(qcard);
        }

    }
}
