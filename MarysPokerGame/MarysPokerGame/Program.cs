using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarysPokerGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Before we call our larger method "GetHandType", we first need to sort the cards.
            Card[] hands = new Card[2];
            hands[0] = new Card(Rank.Eight, Suit.Diamond);
            hands[1] = new Card(Rank.Four, Suit.Diamond);

            Array.Sort(hands);
        }
    }
}
