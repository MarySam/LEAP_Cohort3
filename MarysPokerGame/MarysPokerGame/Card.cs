using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarysPokerGame
{
    public class Card : IComparable<Card>
    {
        public Rank Rank { get; private set; }
        public Suit Suit { get; private set; }


        public Card(Rank rank, Suit suit)
        {
            this.Rank = rank;
            this.Suit = suit;
        }

        public int CompareTo(Card other)
        {
            // t   o
            // RS  RS
            // 2H, 4H
            if (this.Rank == other.Rank && this.Suit == other.Suit) return 0;

            if (this.Rank > other.Rank) return 1;

            if (this.Rank < other.Rank) return -1;

            return 0;
        }
    }
}
