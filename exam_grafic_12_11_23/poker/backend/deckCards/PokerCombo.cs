 
namespace poker.backend.deckCards
{

    internal enum PokerCombination {Senior_Card, Poker, RoyalFlush, StraightFlush, FourOfAKind, FullHouse, Flush, Straight, ThreeOfAKind, TwoPairs, Pair }


    internal static class PokerCombo
    {
        public static PokerCombination GetCombination(IEnumerable<Card> ListOfCardsOnHand) //Найти комбинацию
        {
            
            //Разбиваем на две группы             
            IEnumerable<NormalCard> listNormalCard = ListOfCardsOnHand.Select(card => card).Where(card => card is NormalCard).Select(card => (NormalCard)card);

            IEnumerable<Joker>? listJoker = ListOfCardsOnHand.Select(card => card).Where(card => card is Joker).Select(card => (Joker)card);
 
            if (Poker(listNormalCard, listJoker)) return PokerCombination.Poker;//Покер
            else if (RoyalFlush(listNormalCard)) return PokerCombination.RoyalFlush; //Флеш-Рояль
            else if (StraightFlush(listNormalCard)) return PokerCombination.StraightFlush; //Стрит-флеш
            else if (FourOfAKind(listNormalCard, listJoker)) return PokerCombination.FourOfAKind; //Каре
            else if (FullHouse(listNormalCard, listJoker)) return PokerCombination.FullHouse; //Фул-хаос
            else if (Flush(listNormalCard)) return PokerCombination.Flush; //Флеш
            else if (Straight(listNormalCard)) return PokerCombination.Straight; //Стрит
            else if (ThreeOfAKind(listNormalCard, listJoker)) return PokerCombination.ThreeOfAKind; //Сет
            else if (TwoPairs(listNormalCard, listJoker)) return PokerCombination.TwoPairs; //Две пара
            else if (Pair(listNormalCard, listJoker)) return PokerCombination.Pair; //Пара 
            else return PokerCombination.Senior_Card; 
        }

        public static bool Poker(IEnumerable<NormalCard> groupNormalCards, IEnumerable<Joker> groupJoker)//Покер
        {
             if (groupJoker.Any() && groupNormalCards.GroupBy(card => card.CardDignity).Count() == 1) return true;
         
            return false; //Без джокера не может быть Покера
        }

        public static bool RoyalFlush(IEnumerable<NormalCard> groupNormalCards)//Флеш-Рояль
        {
            
            groupNormalCards = groupNormalCards.OrderBy(card => card.CardDignity);

            return groupNormalCards.Last().CardDignity - groupNormalCards.First().CardDignity <= 4 
                && groupNormalCards.GroupBy(card => card.CardDignity).Count() == groupNormalCards.Count()
                && groupNormalCards.First().CardDignity >= CardDignity.Ten;

        }

        public static bool StraightFlush(IEnumerable<NormalCard> groupNormalCards) => Straight(groupNormalCards) && Flush(groupNormalCards); //Стрит-флеш

        public static bool FourOfAKind(IEnumerable<NormalCard> groupNormalCards, IEnumerable<Joker> groupJoker)//Каре
        {
            if (!groupJoker.Any())
            {
                var groups = groupNormalCards.GroupBy(card => card.CardDignity);
                return groups.Count() == 2 && groups.First().Count() == 1 || groups.First().Count() == 4;
            }

            if (groupJoker.Count() == 1 && ThreeOfAKind(groupNormalCards, new List<Joker>())) return true;
            
            else if (groupJoker.Count() == 2 && Pair(groupNormalCards, new List<Joker>())) return true;

            return false;
        }

        public static bool FullHouse(IEnumerable<NormalCard> groupNormalCards, IEnumerable<Joker> groupJoker)//Фул-хаос
        {
            if (!groupJoker.Any())
            {
                var group = groupNormalCards.GroupBy(card => card.CardDignity);
                return group.Count() == 2 && group.First().Count() == 2 || group.First().Count() == 3;
            }

            int countJoker = groupJoker.Count();

            if (countJoker == 2) return false; //С двумя джокерами никак не может быть фул-хаос

            if (countJoker == 1 && TwoPairs(groupNormalCards, new List<Joker>())) return true;
          
            return false;
        }

        public static bool Flush(IEnumerable<NormalCard> groupNormalCards) => groupNormalCards.GroupBy(card => card.CardSuit).Count() == 1; //Флеш

        public static bool Straight(IEnumerable<NormalCard> groupNormalCards)//Стрит
        {
            groupNormalCards = groupNormalCards.OrderBy(card => card.CardDignity);
 
            return groupNormalCards.Last().CardDignity - groupNormalCards.First().CardDignity <= 4 &&
                   groupNormalCards.GroupBy(card => card.CardDignity).Count() == groupNormalCards.Count();
                              
        }

        public static bool ThreeOfAKind(IEnumerable<NormalCard> groupNormalCards, IEnumerable<Joker> groupJoker)//Сет
        { 
            if (groupJoker.Count() == 2) return true;

            if (groupJoker.Any() && Pair(groupNormalCards, new List<Joker>())) return true;

            var groups = groupNormalCards.GroupBy(card => card.CardDignity);

            foreach (var group in groups)
                if (group.Count() == 3) return true;
            
            return false;
        }

        public static bool TwoPairs(IEnumerable<NormalCard> groupNormalCards, IEnumerable<Joker> groupJoker)//Две пара
        {
            var groups = groupNormalCards.GroupBy(card => card.CardDignity);
            int countPair = 0;

            foreach (var group in groups)
                if (group.Count() == 2) countPair++;

            return countPair == 1 && groupJoker.Any() || countPair >= 2;

        }

        public static bool Pair(IEnumerable<NormalCard> groupNormalCards, IEnumerable<Joker> groupJoker)//Пара
        {
            if (groupJoker.Any()) return true; 

            return groupNormalCards.GroupBy(card => card.CardDignity).Count() < groupNormalCards.Count(); 
        }

    }
}
