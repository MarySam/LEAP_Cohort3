using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarysPokerGame
{
    class HandUtilities
    {
        //GetHandType is a larger method that will call all of our helper methods.
        //This method returns to us the HandType.
        //We need to call our helper methods in this order bc we want the highest possible hand to be returned.
        public static HandTypes GetHandType(Card[] Hand)
        {
            if (IsStraightFlush(Hand))
            {
                return HandTypes.StraightFlush;
            }
            if (IsFourOfAKind(Hand))
            {
                return HandTypes.FourOfAKind;
            }
            if (IsFullHouse(Hand))
            {
                return HandTypes.FullHouse;
            }
            if (IsFlush(Hand))
            {
                return HandTypes.Flush;
            }
            if (IsStraight(Hand))
            {
                return HandTypes.Straight;
            }
            if (IsThreeOfAKind(Hand))
            {
                return HandTypes.ThreeofAKind;
            }
            if (IsTwoPairs(Hand))
            {
                return HandTypes.TwoPair;
            }
            if (IsPair(Hand))
            {
                return HandTypes.Pair;
            }
            //If none of the above, return HighCard.
            return HandTypes.Highcard;
           
        }
        private static bool IsStraightFlush(Card[] Hand)
        {
            //See Straight Method and Flush Method
            if (IsStraight(Hand) && IsFlush(Hand))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsFourOfAKind(Card[] Hand)
        {
            //Example: 2,2,2,2,3             || 3,4,4,4,4
            if (Hand[0].Rank == Hand[3].Rank || Hand[1].Rank == Hand[4].Rank)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Three of A Kind plus One Pair.
        private static bool IsFullHouse(Card[] Hand)
        {
            //Example: 2,2,2,3,3
            if (Hand[0].Rank == Hand[2].Rank && Hand[3].Rank == Hand[4].Rank)
            {
                return true;
            }
            //Example: 3,3,4,4,4
            else if (Hand[0].Rank == Hand[1].Rank && Hand[2].Rank == Hand[4].Rank)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsFlush(Card[] Hand)
        {
            //All the same suit i.e. all Hearts
            //Compare all other cards suits to the first cards suit.
            //If they are all the same suit then return true.
            bool result = false;
            for (int i = 1; i < Hand.Length; i++)
            {
                if (Hand[0].Suit == Hand[i].Suit)
                {
                    result = true;
                }
                else
                {
                    break;
                }
            }
            return result;
        }

        //Example: 2,3,4,5,6
        private static bool IsStraight(Card[] Hand)
        {
            //Check if the difference in Rank between each adjacent card is equal to one.
            bool result = false;
            for (int i = 1; i < Hand.Length; i++)
            {
                if (Hand[i].Rank - Hand[i - 1].Rank == 1)
                {
                    result = true;
                }
                //Checking for Ace Low Straight. That is, if we consider Ace to be low, then a winning hand..
                //..will be A,2,3,4,5. BUT since we sort the Ranks by enum value and Ace is high in our enum...
                //...The cards will be sorted like so..(2,3,4,5,A).  Our method will need to check for this. 
                else if (Hand[i - 1].Rank == Rank.Five && Hand[i].Rank == Rank.Ace)
                {
                    result = true;
                }
                else
                {
                    break;
                }
            }
            return result;
        }

        private static bool IsThreeOfAKind(Card[] Hand)
        {
            bool result = false;
            //Example: 2,2,2,3,4
            if (Hand[0].Rank == Hand[1].Rank && Hand[1].Rank == Hand[2].Rank)
            {
                result = true;
            }
            //Example: 2,3,4,4,4
            else if (Hand[2].Rank == Hand[3].Rank && Hand[3].Rank == Hand[4].Rank)
            {
                result = true;
            }
            //Example: 2,3,3,3,4
            else if (Hand[1].Rank == Hand[2].Rank && Hand[2].Rank == Hand[3].Rank)
            {
                result = true;
            }
            return result;
        }

        private static bool IsTwoPairs(Card[] Hand)
        {
            bool result = false;
            //Example:  2,2,3,3,4
            if (Hand[0].Rank == Hand[1].Rank && Hand[2].Rank == Hand[3].Rank)
            {
                result = true;
            }
            //Example: 2,2,3,4,4
            if (Hand[0].Rank == Hand[1].Rank && Hand[3].Rank == Hand[4].Rank)
            {
                result = true;
            }
            //Example: 2,3,3,4,4
            if (Hand[1].Rank == Hand[2].Rank && Hand[3].Rank == Hand[4].Rank)
            {
                result = true;
            }
            return result;
        }

        private static bool IsPair(Card[] Hand)
        {
            bool result = false;
            //Example: 5,5,6,7,8
            if (Hand[0].Rank == Hand[1].Rank)
            {
                result = true;
            }
            //Example: 4,5,5,6,7
            if (Hand[1].Rank == Hand[2].Rank)
            {
                result = true;
            }
            //Example: 3,4,5,5,6
            if (Hand[2].Rank == Hand[3].Rank)
            {
                result = true;
            }
            //Example: 2,3,4,5,5
            if (Hand[3].Rank == Hand[4].Rank)
            {
                result = true;
            }
            return result;
        }
    }
}
