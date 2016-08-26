using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Tests
{
    [TestFixture]
    public class HandTests
    {

        [Test]
        public void IsHandShowsCorrectly_CorrectShows_PassTheTest()
        {
            var actual = new Hand(new List<ICard>() {
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });

            var expected = "Your hand is: [Face:Three|Suit:Clubs] [Face:Six|Suit:Diamonds] [Face:King|Suit:Hearts] [Face:Two|Suit:Spades] [Face:Seven|Suit:Diamonds]";

            Assert.AreEqual(expected, actual.ToString());

        }

    }
}
