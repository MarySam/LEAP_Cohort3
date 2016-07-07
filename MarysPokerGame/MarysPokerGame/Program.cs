using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarysPokerGame
{
    class Program
    {
        public static bool IsStraightFlush(Card[] Hand)
        {
            if (true)//IsStraight(Hand) && IsFlush(Hand))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsFourOfAKind(Card[] Hand)
        {
            if (Hand[0].Rank == Hand[3].Rank || Hand[1].Rank == Hand[4].Rank)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsFullHouse(Card[] Hand)
        {
            if (Hand[0].Rank == Hand[2].Rank && Hand[4].Rank == Hand[3].Rank)
            {
                return true;
            }

            else if (Hand[4].Rank == Hand[2].Rank && Hand[0].Rank == Hand[1].Rank)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        /*
        public static bool IsFlush(Card[] Hand)
        {
           //For loop.  Iterate through the suits and compare.  If they are the same then return true.
        }

        public static bool IsStraight(Card[] Hand)
        {
            //Make sure that the difference between each card is equal to one.
        }

        public static bool IsThreeOfAKind(Card[] Hand)
        {
        //for loop: i-2,
        }

        public static bool TwoPairs(Card[] Hand)
        {

        }

        public static bool IsPair(Card[] Hand)
        {

        }

        public static void HighCard(Card[] Hand)
        {
            //All other cards that were not filtered above for conditions end up here.
        }
        */
        enum HandTypes
        {
            Highcard,
            Pair,
            TwoPair,
            ThreeofAKind,
            Straight,
            Flush,
            FullHouse,
            FourOfAKind,
            StraightFlush,
        }

        static void Main(string[] args)
        {
            //Before we filter down these methods, we have to first sort the hand.
            Card[] hands = new Card[2];
            hands[0] = new Card(Rank.Eight, Suit.Diamond);
            hands[1] = new Card(Rank.Four, Suit.Diamond);

            Array.Sort(hands);

        }
    }
}
