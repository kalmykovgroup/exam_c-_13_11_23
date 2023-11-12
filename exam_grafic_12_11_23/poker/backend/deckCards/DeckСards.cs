
using System.Text; 

namespace poker.backend.deckCards
{
    internal class DeckСards
    {
        private List<Card> Cards { get; }

        public int Count { get; }

        public DeckСards()
        {

            Cards = new List<Card>();

            //Добавляем все обычные карты
            for (int i = 0; i < 4; i++) //Проход по масти
            {
                for (int j = 2; j <= 14; j++) //Проход по достоинству
                {
                    Cards.Add(new NormalCard((CardSuit)i, (CardDignity)j));
                }
            }

            //Добавляем два джокера
            Cards.Add(new Joker(JokerDignity.Black));
            Cards.Add(new Joker(JokerDignity.Red));

            MixCard();
        }

        public void MixCard()//Перемешать колоду
        {
            Random random = new Random();
            for (int i = Cards.Count - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);

                (Cards[j], Cards[i]) = (Cards[i], Cards[j]);

            }

        }

        public Card GetCard()//Получить из колоды карту
        {       
            Card card = Cards.Last(); //Сначала сохранили
            Cards.RemoveAt(Cards.Count - 1);//Потом удалили из колоды
           
            return card;
        } 


         
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (Card card in Cards)
                stringBuilder.Append(card.ToString());

            return stringBuilder.ToString();
        }


    }
}
