using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poker.backend.deckCards
{
    enum CardSuit { Spades, Hearts, Diamonds, Clubs }
    internal enum CardDignity { Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace }

    internal class NormalCard : Card
    {
        public CardSuit CardSuit { get; } //Карточная масть
        public CardDignity CardDignity { get; } //Карточное достоинство


        public NormalCard(CardSuit cardSuit, CardDignity cardDignity)
        {
            CardSuit = cardSuit;
            CardDignity = cardDignity;
        }

        public override string GetCardSuit() => CardSuit.ToString();
        public override string GetCardDignity() => ((int)CardDignity).ToString();

         
    }
}
