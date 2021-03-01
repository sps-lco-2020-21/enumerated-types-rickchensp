using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerEnumLibrary;

namespace ExtendedEnumConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Poker();
            Colour();
        }

        static void Poker()
        {
            List<Card> allCards = PokerUtilities.AllCards();
            List<Card> shuffled = PokerUtilities.ShuffledCards(allCards);
            List<Card> hand1 = shuffled.RandomHand(5);
            List<CardValues> longestRun = hand1.LongestRun2();
            List<Card> pairs = hand1.Pairs();
            Card card1 = "TC".NameToCard();
            Card card2 = "9D".NameToCard();
        }

        static void Colour()
        {
            ColourUtilities.PrintColours();
            int c1 = (int)Colours.Red;
            int c2 = (int)Colours.Blue;
            bool isPurple = ((c1 + c2) & (int)Colours.Purple) == (int)Colours.Purple;
            Debug.Assert(isPurple == true);
            Console.ReadKey();
        }
    }
}
