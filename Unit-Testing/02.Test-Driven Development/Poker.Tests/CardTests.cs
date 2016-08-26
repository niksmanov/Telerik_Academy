using NUnit.Framework;
using Poker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Tests
{
    [TestFixture]
    public class CardTests
    {

        [Test]
        public void IsCardShowsCorrectly_CorrectShows_PassTheTest()
        {
            var actual = "Current card is: " + new Card(CardFace.Ace, CardSuit.Clubs);
            var expected = "Current card is: [Face:Ace|Suit:Clubs]";
            StringAssert.Contains(expected, actual.ToString());
        }

    }
}
