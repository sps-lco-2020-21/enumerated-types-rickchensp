using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerEnumLibrary
{
    public static class PokerUtilities
    {
        public static List<Card> AllCards()
        {
            List<Card> allCards = new List<Card> { };
            foreach(Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (CardValues value in Enum.GetValues(typeof(CardValues)))
                {
                    allCards.Add(new Card(value, suit));
                }
            }

            return allCards;
        }
    }
}
