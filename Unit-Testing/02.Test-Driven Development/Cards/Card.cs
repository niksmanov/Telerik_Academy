using System;

namespace Poker
{
    public class Card : ICard
    {
        private const string CardOutput = "[Face:{0}|Suit:{1}]";

        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            return string.Format(CardOutput, this.Face, this.Suit);
        }
    }
}
