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
            if (IsStraight(Hand) && IsFlush(Hand))
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

        public static bool IsFlush(Card[] Hand)
        {

        }

        public static bool IsStraight(Card[] Hand)
        {

        }

        public static bool IsThreeOfAKind(Card[] Hand)
        {

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

            Array.Sort(hand);

        }
    }
}
