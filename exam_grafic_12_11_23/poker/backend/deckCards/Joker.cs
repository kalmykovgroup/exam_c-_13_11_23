

namespace poker.backend.deckCards
{
    enum JokerSuit { Joker }
    enum JokerDignity { Red, Black } 

    internal class Joker : Card
    {
        public JokerSuit CardSuit { get; }
        public JokerDignity CardDignity { get; }

        public Joker(JokerDignity jokerDignity)
        {
            CardDignity = jokerDignity;
            CardSuit = JokerSuit.Joker;
        }

        public override string GetCardSuit() => CardSuit.ToString();
        public override string GetCardDignity() => CardDignity.ToString();

         
    }
}
