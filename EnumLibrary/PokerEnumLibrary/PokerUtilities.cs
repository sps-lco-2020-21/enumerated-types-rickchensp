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
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (CardValues value in Enum.GetValues(typeof(CardValues)))
                {
                    allCards.Add(new Card(value, suit));
                }
            }

            return allCards;
        }

        public static Card NameToCard(this string name)
        {
            Dictionary<char, int> cards = new Dictionary<char, int> { {'T', 10}, { 'J', 11 } , { 'Q', 12 } , { 'K', 13 } };
            Dictionary<char, Suits> suits =
                    new Dictionary<char, Suits> { { 'D', Suits.Diamonds }, { 'H', Suits.Hearts }, { 'S', Suits.Spades }, { 'C', Suits.Clubs } };
            bool isInt = int.TryParse(name[0].ToString(), out int num);
            if(isInt)
                return new Card((CardValues)(1 << num - 1), suits[name[1]]);
            return new Card((CardValues)(1 << (cards[name[0]] - 1)), suits[name[1]]);
        }
        public static List<Card> ShuffledCards(List<Card> allCards)
        {
            List<Card> shuffled = new List<Card> { };
            List<int> random = new List<int> { };
            Random rd = new Random();
            for (int i = 1; i <= 52; ++i)
            {
                int randint = rd.Next(0, 52);
                while (random.Contains(randint))   //while the number is not already generated
                {
                    randint = rd.Next(0, 52);
                }
                random.Add(randint);
            }
            foreach (int randint in random)
            {
                shuffled.Add(allCards[randint]);
            }
            return shuffled;
        }

        public static List<Card> RandomHand(this List<Card> shuffled, int n)
        {
            return shuffled.Take(n).ToList();
        }

        public static List<CardValues> FindLongestRun(int cardsBinary)
        {
            List<CardValues> longestRun = new List<CardValues> { };
            int count = 0, start = 0;
            for (int i = 14; i >= 0; --i)
            {
                if (cardsBinary % 2 == 1)  //if a 1 is detected
                    count += 1;
                else
                {
                    if (count > longestRun.Count())
                    {
                        longestRun.Clear();
                        for (int j = 0; j < count; ++j)
                        {
                            if (start + j == 13)
                                longestRun.Add(CardValues.Ace);  //if ace as high is included in longestRun
                            else
                                longestRun.Add((CardValues)(1 << start + j));  //add corresponding CardValue to longestRun
                        }
                    }
                    start += count + 1;  //reset start and count
                    count = 0;
                }
                cardsBinary = cardsBinary >> 1;// go to next bit
            }
            return longestRun;
        }

        public static List<CardValues> LongestRun2(this List<Card> hand)
        {
            int cardsBinary = 0;
            foreach (Card card in hand)
                cardsBinary = cardsBinary | (int)card.Value;  //bitwise or all the values to get a string of 1s and 0s

            if (cardsBinary % 2 == 1)
            {
                cardsBinary = cardsBinary + (1 << 13);  //when Ace counts as high, add Ace as a 14th card
            }
            return FindLongestRun(cardsBinary);
        }
    }
}
