using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerEnumLibrary
{
    public static class ColourUtilities
    {
        public static void PrintColours()
        {
            foreach (Colours colour in Enum.GetValues(typeof(Colours)))
            {
                Console.WriteLine("{0:D}  {0:G}", colour);
            }
        }
    }
}
