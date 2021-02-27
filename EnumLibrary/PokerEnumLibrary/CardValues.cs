using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerEnumLibrary
{
    public enum CardValues
    {
        Ace = 1 << 0, 
        Two = 1 << 1, 
        Three = 1 << 2, 
        Four = 1 << 3,
        Five = 1 << 4,
        Six = 1 << 5,
        Seven = 1 << 6,
        Eight = 1 << 7,
        Nine = 1 << 8,
        Ten = 1 << 9,
        Jack = 1 << 10,
        Queen = 1 << 11,
        King = 1 << 12
    }
}
