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

        public static bool IsFourOfAKind(Card[] Hand)
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
        public static bool IsFullHouse(Card[] Hand)
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

        public static bool IsFlush(Card[] Hand)
        {
            //All the same suit i.e. all Hearts
            //Iterate through the cards and compare each suit using two pointers.  
            //If they are all the same then return true.
            int j = 0;
            bool result = false;
            for (int i = 1; i < Hand.Length; i++)
            {
                if (Hand[i].Suit == Hand[j].Suit)
                {
                    j++;
                    result = true;
                }
                else
                {
                    break;
                }
            }
            return result;
        }

        //Example: 1,2,3,4,5
        public static bool IsStraight(Card[] Hand)
        {
            //Iterate through the cards and check that the difference between each rank is equal to one.
            bool result = false;
            for (int i = 1; i < Hand.Length; i++)
            {
                if (Hand[i].Rank - Hand[i - 1].Rank == 1)
                {
                    result = true; ;
                }
                else
                {
                    break;
                }
            }
            return result;
        }

        public static bool IsThreeOfAKind(Card[] Hand)
        {
            //Use suit at index 2 to compare to the rest of the cards.
            bool result = false;
            for (int i =2; i<Hand.Length; i++)
            {
                //Example: 2,2,2,3,4
                if(Hand[i].Rank == Hand[i-1].Rank && Hand[i].Rank == Hand[i-2].Rank)
                {
                    result = true;
                }
                //Example: 1,2,3,3,3
                else if (Hand[i].Rank == Hand[i+1].Rank && Hand[i].Rank == Hand[i+2].Rank)
                {
                    result = true;
                }
                //Example: 1,3,3,3,4
                else if (Hand[i].Rank == Hand[i-1].Rank && Hand[i].Rank == Hand[i+2].Rank)
                {
                    result = true;
                }
            }
            return result;
        }

        public static bool TwoPairs(Card[] Hand)
        {

        }

        public static bool IsPair(Card[] Hand)
        {

        }

        public static void HighCard(Card[] Hand)
        {
            //If all of the other HandTypes return false then that means the user has a HighCard.
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
