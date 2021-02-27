using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerEnumLibrary
{
    [Flags]
    public enum Colours
    {
        Red = 1 << 0,
        Orange = 1 << 1,
        Yellow = 1 << 2,
        Green = 1 << 3,
        Blue = 1 << 4,
        Indigo = 1 << 5,
        Violet = 1 << 6,

        Purple = Red | Blue,

    }
}
