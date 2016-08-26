using System;
using System.Collections.Generic;

namespace Poker
{
    class PokerExample
    {
        static void Main()
        {
            ICard card = new Card(CardFace.Ace, CardSuit.Clubs);
            Console.WriteLine("Current card is: " + card + Environment.NewLine);

            ///Normal hand\\\
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });

            /////Flush\\\
            //IHand hand = new Hand(new List<ICard>() {
            //    new Card(CardFace.Ace, CardSuit.Clubs),
            //    new Card(CardFace.Ace, CardSuit.Clubs),
            //    new Card(CardFace.King, CardSuit.Clubs),
            //    new Card(CardFace.King, CardSuit.Clubs),
            //    new Card(CardFace.Seven, CardSuit.Clubs),
            //});

            /////Four of a kind\\\
            //IHand hand = new Hand(new List<ICard>() {
            //    new Card(CardFace.Ace, CardSuit.Clubs),
            //    new Card(CardFace.Ace, CardSuit.Diamonds),
            //    new Card(CardFace.Ace, CardSuit.Hearts),
            //    new Card(CardFace.Ace, CardSuit.Spades),
            //    new Card(CardFace.Eight, CardSuit.Clubs),
            //});

            /////One pair\\\
            //IHand hand = new Hand(new List<ICard>() {
            //    new Card(CardFace.Ace, CardSuit.Clubs),
            //    new Card(CardFace.Ace, CardSuit.Diamonds),
            //    new Card(CardFace.Five, CardSuit.Hearts),
            //    new Card(CardFace.Jack, CardSuit.Spades),
            //    new Card(CardFace.Eight, CardSuit.Clubs),
            //});

            /////Two pairs\\\
            //IHand hand = new Hand(new List<ICard>() {
            //    new Card(CardFace.Ace, CardSuit.Clubs),
            //    new Card(CardFace.Ace, CardSuit.Diamonds),
            //    new Card(CardFace.Five, CardSuit.Hearts),
            //    new Card(CardFace.Jack, CardSuit.Spades),
            //    new Card(CardFace.Jack, CardSuit.Clubs),
            //});

            /////Straight Flush\\\
            //IHand hand = new Hand(new List<ICard>() {
            //    new Card(CardFace.Jack, CardSuit.Clubs),
            //    new Card(CardFace.Ten, CardSuit.Clubs),
            //    new Card(CardFace.Nine, CardSuit.Clubs),
            //    new Card(CardFace.Eight, CardSuit.Clubs),
            //    new Card(CardFace.Seven, CardSuit.Clubs),
            //});

            /////Full House\\\
            //IHand hand = new Hand(new List<ICard>() {
            //    new Card(CardFace.Six, CardSuit.Diamonds),
            //    new Card(CardFace.Six, CardSuit.Hearts),
            //    new Card(CardFace.Nine, CardSuit.Clubs),
            //    new Card(CardFace.Nine, CardSuit.Spades),
            //    new Card(CardFace.Nine, CardSuit.Clubs),
            //});

            /////Straight\\\
            //IHand hand = new Hand(new List<ICard>() {
            //    new Card(CardFace.King, CardSuit.Diamonds),
            //    new Card(CardFace.Queen, CardSuit.Hearts),
            //    new Card(CardFace.Jack, CardSuit.Clubs),
            //    new Card(CardFace.Ten, CardSuit.Spades),
            //    new Card(CardFace.Nine, CardSuit.Clubs),
            //});

            Console.WriteLine(hand + Environment.NewLine);

            IPokerHandsChecker checker = new PokerHandsChecker();
            Console.WriteLine("Is this hand valid: " + checker.IsValidHand(hand));
            Console.WriteLine("Do you have one pair: " + checker.IsOnePair(hand));
            Console.WriteLine("Do you have two pairs: " + checker.IsTwoPair(hand));
            Console.WriteLine("Do you have a flush: " + checker.IsFlush(hand));
            Console.WriteLine("Do you have four of a kind: " + checker.IsFourOfAKind(hand));
            Console.WriteLine("Do you have three of a kind: " + checker.IsThreeOfAKind(hand));
            Console.WriteLine("Do you have straight flush: " + checker.IsStraightFlush(hand));
            Console.WriteLine("Do you have a full house: " + checker.IsFullHouse(hand));
            Console.WriteLine("Do you have a straight: " + checker.IsStraight(hand));
            Console.WriteLine("Do you have high card: " + checker.IsHighCard(hand));
            
        }
    }
}
