using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarysPokerGame
{
   public class Card:IComparable<Card>
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
            if (other == null) return 1;

            if (other.Rank == this.Rank)
            {
                return other.Suit.CompareTo(this.Suit);
            }
            else
            {
                return other.Rank.CompareTo(this.Rank);
            }
        }
    }
}
