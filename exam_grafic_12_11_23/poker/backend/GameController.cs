
using Microsoft.VisualBasic.ApplicationServices;
using poker.backend.deckCards; 

namespace poker.backend
{
 
    internal class GameController
    {
        public static List<Player> Players { get; }

        static GameController()
        {
            if (Players is null)
            {
                Players = PlayerDto.FromDto(); //Загрузка данных
            }
        }
  

        public Player Player { get; } //Игрок, которым мы играем 

        public float Bet   { get; set; } //Ставка
        public float PreviousBet  { get; set; } //Предыдущая ставка
        public float Bank  { get; set; } //Текущая ставка с расчетов комбинации на руках

        public DeckСards DeckСards { get; set; } //Текущая колода карт

        public PokerCombination Combination { get; set; } // Комбинация на руке

        public (Card card_1, Card card_2, Card card_3, Card card_4, Card card_5) CardsOnHand;  //Сдесь хранятся карты которые у нас на руках

        
        public GameController(Player SelectedPlayer)
        {
            if (SelectedPlayer.Balance <= 0) SelectedPlayer.Balance = Player.InitialBalance;

            Player = SelectedPlayer;
            if(!Players.Any(player => player.Id == SelectedPlayer.Id))//Если игрок не найден
            {
                Players.Add(SelectedPlayer);
                PlayerDto.ToDto(Players); //Сохранение состояния игры 
            }     
                
          DeckСards = new DeckСards(); //Новая колода карт, по умолчанию уже перетасована 
        }

        
        public void AddBet(int num)//Добавить ставку
        {  
            Bet += num;
            if (Bet > Player.Balance) Bet = Player.Balance;
            Bank = Bet; 
        }

        public string TakeBet(int num)//Отнять ставку
        {
            Bet -= num;
            if (Bet < 0) Bet = 0; 
            return Bet.ToString();
        }

        public void VaBank() => AddBet(Player.Balance); //Ва-Банк

        public void HandOutCards() //Раздать карты
        {  
            Player.Balance -= (int)Bet; //Снимаем с баланса ставку

            //Делаем раздачу, получить 5 карт     
             CardsOnHand.card_1 = DeckСards.GetCard();
             CardsOnHand.card_2 = DeckСards.GetCard();
             CardsOnHand.card_3 = DeckСards.GetCard();
             CardsOnHand.card_4 = DeckСards.GetCard();
             CardsOnHand.card_5 = DeckСards.GetCard();


            Combination = PokerCombo.GetCombination(new List<Card>{
              CardsOnHand.card_1, CardsOnHand.card_2,  CardsOnHand.card_3,
              CardsOnHand.card_4, CardsOnHand.card_5,
            }); //Просчитать комбинацию карт 

            RecalcBank();//сделать перерасчет банка

            //Забираем все что осталось в банке после первой игры, так как пользователь может завершить досрочно.
            //Сохраняем в базу текущий результат 
            Player.Balance += (int)Bank;

            if(Player.Balance > Player.Record) Player.Record = Player.Balance;

            PlayerDto.ToDto(Players);  //Сохраняем обновленные данные

        }

        

        public void ChangeCard(IEnumerable<Action> actions)//Заменить карты.
        {

            foreach (var action in actions) //Обновить карты
                action.Invoke(); //Вызываются функции, которые меняю карты (ChangeCard_1() и т.д)

            //Отменяем банк, по первой раздачи
            Player.Balance -= (int)Bank;

            Combination = PokerCombo.GetCombination(new List<Card>{
              CardsOnHand.card_1, CardsOnHand.card_2,  CardsOnHand.card_3,
              CardsOnHand.card_4, CardsOnHand.card_5,
            }); //Просчитать комбинацию карт 
            RecalcBank();//сделать перерасчет банка

            Player.Balance += (int)Bank; //Забираем все что осталось в банке после игры  
            if (Player.Balance > Player.Record) Player.Record = Player.Balance;
            PlayerDto.ToDto(Players); //Сохраняем обновленные данные

        }

        //Поменять карту
        public void ChangeCard_1() => CardsOnHand.card_1 = DeckСards.GetCard();
        public void ChangeCard_2() => CardsOnHand.card_2 = DeckСards.GetCard();
        public void ChangeCard_3() => CardsOnHand.card_3 = DeckСards.GetCard();
        public void ChangeCard_4() => CardsOnHand.card_4 = DeckСards.GetCard();
        public void ChangeCard_5() => CardsOnHand.card_5 = DeckСards.GetCard();

        private Dictionary<PokerCombination, string> RusComboName = new Dictionary<PokerCombination, string>(){
            {PokerCombination.Senior_Card, "Старшая карта"},
            {PokerCombination.Poker, "Покер" },  {PokerCombination.RoyalFlush, "Флеш-Рояль" },  {PokerCombination.StraightFlush, "Стрит-флеш" }, 
            {PokerCombination.FourOfAKind, "Каре" },  {PokerCombination.FullHouse, "Фул-хаос" },  {PokerCombination.Flush, "Флеш" }, 
            {PokerCombination.Straight, "Стрит" },  {PokerCombination.ThreeOfAKind, "Сет" },  {PokerCombination.TwoPairs, "Две пары" },  
            {PokerCombination.Pair, "Пара" }, 
        };

        public string GetPokerCombinationName() => RusComboName[Combination];

        public void RecalcBank()//сделать перерасчет банка
        {            
             switch (Combination) 
            {
                case PokerCombination.Poker: Bank = Bet * 200; break;                //Покер
                case PokerCombination.RoyalFlush: Bank = Bet * 100; break;           //Флеш-Рояль
                case PokerCombination.StraightFlush: Bank = Bet * 50; break;         //Стрит-флеш
                case PokerCombination.FourOfAKind: Bank = Bet * 20; break;           //Каре
                case PokerCombination.FullHouse: Bank = Bet * 7; break;              //Фул-хаос
                case PokerCombination.Flush: Bank = Bet * 5; break;                  //Флеш
                case PokerCombination.Straight: Bank = Bet * 4; break;               //Стрит
                case PokerCombination.ThreeOfAKind: Bank = Bet * 3; break;           //Сет
                case PokerCombination.TwoPairs: Bank = Bet * 2; break;               //Две пара
                case PokerCombination.Pair: Bank = Bet * 1; break;                   //Пара  
                case PokerCombination.Senior_Card: { Bank = 0;  break; }

                default: throw new ArgumentException();
            } 
        }

 
        public void FinishCurrentGame() //Забрать выйгрыш, Вернуть в исходное состояние 
        { 
            PreviousBet = Bet; //Сохраняем предыдущую ставку для повтора
            Bet = 0;
            Combination = PokerCombination.Senior_Card; //Сбрасываем комбинацию    
            DeckСards = new DeckСards(); //Создаем новую колоду      
        }



       
 
       

    }
}
