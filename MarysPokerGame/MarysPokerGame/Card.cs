using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarysPokerGame
{

    //IComparable Interface: Defines a generalized type-specific comparison method that a value type..
    //..or class implements to order or sort its instances.

    //Here, we attached IComparable to the card class so that when we call array.sort and pass in.. 
    //..instances of a card array (our hand), the .sort method will come to the card class and call
    //..the "compare.To" method below.
    public class Card : IComparable<Card>
    {
        //Our card class has two properties, rank and  suit.  
        //The set is private so that after the hand has been set, it cannot be changed.
        public Rank Rank { get; private set; }
        public Suit Suit { get; private set; }

        //Constructor.  When a card class is instantiated, a rank and suit must also be passed in as an argument.
        public Card(Rank rank, Suit suit)
        {
            this.Rank = rank;
            this.Suit = suit;
        }

        //CompareTo Method:  Compares the current instance with another object of the same type and 
        //..returns an integer that indicates whether the current instance precedes, follows, 
        //..or occurs in the same position in the sort order as the other object.
        public int CompareTo(Card other)
        {
            // this   other
            // RS      RS
            // 2H      4H
            if (this.Rank == other.Rank && this.Suit == other.Suit) return 0;

            if (this.Rank > other.Rank) return 1;

            if (this.Rank < other.Rank) return -1;

            //If none of the above condition checks are true then return 0.  
            //Meaning...we only have one card so there is nothing to compare it to.
            return 0;
        }
    }
}
