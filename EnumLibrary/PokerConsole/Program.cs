﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerEnumLibrary;

namespace PokerEnumConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> allCards = PokerUtilities.AllCards();
        }
    }
}
