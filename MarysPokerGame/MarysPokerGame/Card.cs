using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarysPokerGame
{

    //IComparable Interface(MSDN Def): Defines a generalized type-specific comparison method that a value type..
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

        //Constructor.
        //When a card class is instantiated, a rank and suit must also be passed in as an argument.
        //This is a condition that we have "pre-set" for our own purposes an object does not always have to
        //..take in a parameter when it is instantiated for use.
        public Card(Rank rank, Suit suit)
        {
            this.Rank = rank;
            this.Suit = suit;
        }

        //CompareTo Method(MSDN Def):  Compares the current instance with another object of the same type and 
        //..returns an integer that indicates whether the current instance precedes, follows, 
        //..or occurs in the same position in the sort order as the other object.

        //All Ranks have an associated enum value in which we could use to compare to another Rank.  
        //The Rank at the top of the enum list will have a smaller value than the Rank at the bottom.
        //Rank Order: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A
        //For example, Two has an enum value of 0 and Ace has an enum value of 12.  
        public int CompareTo(Card other)
        {
            //BY RANK

            //If the "other" card is null then it should come after our card ("this"). So, "this" card should rtrn 1.
            if (other == null) return 1;

            // If the rank of "this" card is higher, it should come after the "other" card.
            // Ex: this = KD, other = 5H.  Order should be: 5H, KD
            if (this.Rank > other.Rank) return 1;

            // If the rank of "this" card is lower, it should come before the "other" card.
            // Ex: this = KD, other = AS.  Order should be: KD, AS
            if (this.Rank < other.Rank) return -1;

            //BY SUIT

            // If the ranks are equal (already checked above), we'll order the cards by suit.
            // Suit Order: Clubs, Diamonds, Hearts, Spades.

            // If the suit of "this" card is higher than the "other", it should come after the "other" card.
            // Ex: this = KD, other = KC.  Order should be: KC, KD.
            if (this.Suit > other.Suit)
            {
                return 1;
            }

            // If the suit of this card is lower in the order, it should come before the other card.
            // Ex: this = KD, other = KS.  Order should be: KD, KS.
            if (this.Suit < other.Suit)
            {
                return -1;
            }

            // If none of the above conditions is met, the cards are equal (Same rank and suit).
            return 0;

            //*Note that for our game of Poker, we are not ranking the suits.  
            //If the ranks of two cards are the same then this code will still return 0.
            //That is, if(this.Rank == other.Rank) return 0;
            //The suit ranking could come in handy for other card games with greater than 2 decks of cards 
            //..or for where we want to compare the suits.
        }
    }
}
