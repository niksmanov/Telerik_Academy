using System;
using System.Collections.Generic;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {

        private const int ValidHand = 5;

        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count != ValidHand)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsStraightFlush(IHand hand)
        {
            bool check = false;
            for (int i = 0; i < 1; i++)
            {
                if (hand.Cards[i].Face > hand.Cards[i + 1].Face && hand.Cards[i + 1].Face == (hand.Cards[i].Face - 1) &&
                    hand.Cards[i + 1].Face > hand.Cards[i + 2].Face && hand.Cards[i + 2].Face == (hand.Cards[i + 1].Face - 1) &&
                    hand.Cards[i + 2].Face > hand.Cards[i + 3].Face && hand.Cards[i + 3].Face == (hand.Cards[i + 2].Face - 1) &&
                    hand.Cards[i + 3].Face > hand.Cards[i + 4].Face && hand.Cards[i + 4].Face == (hand.Cards[i + 3].Face - 1))
                {
                    if (hand.Cards[i].Suit == hand.Cards[i + 1].Suit &&
                    hand.Cards[i + 1].Suit == hand.Cards[i + 2].Suit &&
                    hand.Cards[i + 2].Suit == hand.Cards[i + 3].Suit &&
                    hand.Cards[i + 3].Suit == hand.Cards[i + 4].Suit)
                    {
                        check = true;
                    }
                }
                else
                {
                    check = false;
                }
            }
            return check;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            int count = 1;
            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                if (hand.Cards[i].Face == hand.Cards[i + 1].Face)
                {
                    count++;
                }
            }
            if (count == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFullHouse(IHand hand)
        {
            bool check = false;
            for (int i = 0; i < hand.Cards.Count - 3; i++)
            {
                if (hand.Cards[i].Face == hand.Cards[i + 1].Face &&
                    hand.Cards[i + 2].Face == hand.Cards[i + 3].Face &&
                    hand.Cards[i + 3].Face == hand.Cards[i + 4].Face)
                {
                    check = true;
                }
            }
            return check;
        }

        public bool IsFlush(IHand hand)
        {
            int count = 1;
            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                if (hand.Cards[i].Suit == hand.Cards[i + 1].Suit)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            if (count == ValidHand)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStraight(IHand hand)
        {
            int count = 1;
            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                if (hand.Cards[i].Face > hand.Cards[i + 1].Face &&
                    hand.Cards[i + 1].Face == (hand.Cards[i].Face - 1))
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            if (count == ValidHand)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsThreeOfAKind(IHand hand)
        {

            int count = 1;
            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                if (hand.Cards[i].Face == hand.Cards[i + 1].Face)
                {
                    count++;
                }
            }
            if (count == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsTwoPair(IHand hand)
        {
            int count = 0;
            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                if (hand.Cards[i].Face == hand.Cards[i + 1].Face)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsOnePair(IHand hand)
        {
            bool check = false;
            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                if (hand.Cards[i].Face == hand.Cards[i + 1].Face)
                {
                    check = true;
                }
            }
            return check;
        }

        public bool IsHighCard(IHand hand)
        {
            var cards = new List<int>();
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                cards.Add((int)hand.Cards[i].Face);
            }
            cards.Sort();
            int highCard = cards[cards.Count - 1];
            var highCardName = Enum.GetName(typeof(CardFace), highCard);
            Console.WriteLine("Your high card is " + highCardName);
            return true;
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
