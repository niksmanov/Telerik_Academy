using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Tests
{
    [TestFixture]
    public class PokerHandsCheckerTests
    {
        [Test]
        public void IsValidHand_ValidHand_ReturnsTrue()
        {
            var hand = new Hand(new List<ICard>() {
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds)
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            bool check = checker.IsValidHand(hand);
            Assert.True(check);
        }

        [Test]
        public void IsFourOfAKind_FourOfAKind_ReturnsTrue()
        {
            var hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            bool check = checker.IsFourOfAKind(hand);
            Assert.True(check);
        }

        [Test]
        public void IsFlush_Flush_ReturnsTrue()
        {
            var hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            bool check = checker.IsFlush(hand);
            Assert.True(check);
        }

        [Test]
        public void IsStraightFlush_StraightFlush_ReturnsTrue()
        {
            var hand = new Hand(new List<ICard>() {
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            bool check = checker.IsStraightFlush(hand);
            Assert.True(check);
        }

        [Test]
        public void IsFullHouse_FullHouse_ReturnsTrue()
        {
            var hand = new Hand(new List<ICard>() {
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            bool check = checker.IsFullHouse(hand);
            Assert.True(check);
        }

        [Test]
        public void IsStraight_Straight_ReturnsTrue()
        {
            var hand = new Hand(new List<ICard>() {
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            bool check = checker.IsStraight(hand);
            Assert.True(check);
        }

        [Test]
        public void IsThreeOfAKind_ThreeOfAKind_ReturnsTrue()
        {
            var hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            bool check = checker.IsThreeOfAKind(hand);
            Assert.True(check);
        }

        [Test]
        public void IsTwoPair_TwoPair_ReturnsTrue()
        {
            var hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            bool check = checker.IsTwoPair(hand);
            Assert.True(check);
        }

        [Test]
        public void IsOnePair_OnePair_ReturnsTrue()
        {
            var hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            bool check = checker.IsOnePair(hand);
            Assert.True(check);
        }

        [Test]
        public void IsHighCard_HighCard_ReturnsTrue()
        {
            var hand = new Hand(new List<ICard>() {
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();
            bool check = checker.IsHighCard(hand);
            Assert.True(check);
        }
    }
}