using System;
using System.Collections.Generic;

namespace Poker
{
    public class Hand : IHand
    {
        private const string HandOutput = "Your hand is: {0}";

        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            return string.Format(HandOutput, string.Join(" ", this.Cards));
        }
    }
}
