using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerEnumLibrary
{
    public class Card
    {
        private CardValues _value;
        private Suits _suit;
        public Card(CardValues value, Suits suit)
        {
            _value = value;
            _suit = suit;         
        }
        public override string ToString()
        {
            return _value.ToString() + " of " + _suit.ToString();
        }

        public CardValues Value { get { return _value; } }
    }
}
