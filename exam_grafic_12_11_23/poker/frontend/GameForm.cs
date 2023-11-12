
using poker.backend;
using poker.frontend;

namespace poker
{

    internal partial class GameForm : Form
    {
        internal GameController GameController { get; }

        public GameForm(Player user)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.None;

            GameController = new GameController(user);
            balance.Text = GameController.Player.Balance.ToString();


            List<(string key, string value)> pairs = new List<(string, string)>()
            {
                ("Покер", "X200"), ("Флеш-Рояль", "X100"),
                ("Стрит-Флеш", "X50"), ("Каре", "X20"),
                ("Фул-Хаос", "X7"), ("Флеш", "X5"),
                ("Стрит", "X4"), ("Сет", "X3"),
                ("Две Пары", "X2"), ("Пара", "X1"),
            };

            var labels = pairs.Select(item =>
            {
                (Label key, Label value) pair = (new Label(), new Label());
                pair.key.Text = item.key;
                pair.key.ForeColor = SystemColors.ButtonFace;
                pair.value.Text = item.value;
                pair.value.ForeColor = SystemColors.ButtonFace;
                return pair;
            });

            int i = 0;
            foreach (var label in labels)
            {
                tableLayoutPanelPrice.Controls.Add(label.key, 0, i);
                tableLayoutPanelPrice.Controls.Add(label.value, 1, i);
                i++;
            }


        }

        //Вернуться назад
        private void btn_back_Click(object sender, EventArgs e) => FormController.NextView(this, FormController.ActionInput);

        //Выход из приложения
        private void btn_exit_Click(object sender, EventArgs e) => FormController.ExitApp();


        //Клик по фишкам 
        private void btn_chip_Click(object sender, EventArgs e)
        {

            if (sender is System.Windows.Forms.Button btn)
            {
                if (btn == btn_chip_100) GameController.AddBet(100);
                if (btn == btn_chip_500) GameController.AddBet(500);
                if (btn == btn_chip_1000) GameController.AddBet(1000);
                if (btn == btn_chip_5000) GameController.AddBet(5000);
                if (btn == btn_chip_20000) GameController.AddBet(20_000);
                if (btn == btn_chip_100000) GameController.AddBet(100_000);
                if (btn == btn_repeat_bet) GameController.AddBet((int)GameController.PreviousBet);
                if (btn == btn_chip_2)
                {
                    if (int.TryParse(input_money.Text, out int result))
                    {
                        GameController.TakeBet(result / 2);
                    }

                }
                if (btn == btn_chip_x2)
                {
                    if (int.TryParse(input_money.Text, out int result))
                    {
                        GameController.AddBet(result);
                    }
                }
                if (btn == btn_chip_vabank) GameController.VaBank();

                input_money.Text = GameController.Bet.ToString();
            }

        }


        private void place_a_bet_Click(object sender, EventArgs e) //Сделать ставку
        {
            if (GameController.Bet == 0) return; //Игнорировать

            GameController.HandOutCards(); //Передали управление в контроллер        
            GameStateReplacingСards();     //Поменяли состояние игры
        }

        private void GameStateReplacingСards() //Состояние игры после раздачи
        {
            printCards();                  //Напечатали карты на экране 
            balance.Text = GameController.Player?.Balance.ToString(); //Обновляем баланс 
            label_combo.Text = GameController.GetPokerCombinationName(); //Обновили отоброжение комбинации

            label_bank_sum.Text = GameController.Bank.ToString(); //Обновили информацию о текущем состоянии банка(кона)
            initial_bid.Text = GameController.Bet.ToString(); //Вывели на экран нашу ставку

            groupBoxChips.Visible = false; //Убрали поле ввода ставки
            label_bet_text.Visible = false; //Убрали label 

            panelBankLabel.Visible = true; //Показали label банк
            card_replacement.Visible = true; //Показали банк

        }

        public void printCards()
        {
            //Вывели карты на экран
            btn_card_1.Image = Image.FromFile(@"..\..\..\Frontend/img/cards/" + GameController.CardsOnHand.card_1.GetCardSuit() + "/" + GameController.CardsOnHand.card_1.GetCardDignity() + ".gif");
            btn_card_2.Image = Image.FromFile(@"..\..\..\Frontend/img/cards/" + GameController.CardsOnHand.card_2.GetCardSuit() + "/" + GameController.CardsOnHand.card_2.GetCardDignity() + ".gif");
            btn_card_3.Image = Image.FromFile(@"..\..\..\Frontend/img/cards/" + GameController.CardsOnHand.card_3.GetCardSuit() + "/" + GameController.CardsOnHand.card_3.GetCardDignity() + ".gif");
            btn_card_4.Image = Image.FromFile(@"..\..\..\Frontend/img/cards/" + GameController.CardsOnHand.card_4.GetCardSuit() + "/" + GameController.CardsOnHand.card_4.GetCardDignity() + ".gif");
            btn_card_5.Image = Image.FromFile(@"..\..\..\Frontend/img/cards/" + GameController.CardsOnHand.card_5.GetCardSuit() + "/" + GameController.CardsOnHand.card_5.GetCardDignity() + ".gif");

        }

        private void btn_change_cards_Click(object sender, EventArgs e) //Кнопка Поменять карты
        {
            if (SelectedButtons.Count == 0) return; //Игнорировать

            GameController.ChangeCard(SelectedButtons.Values);//Заменить карты. Передаем управление на контроллер            

            printCards(); //Обновить карты на экране 
            label_combo.Text = GameController.GetPokerCombinationName(); //Обновили отоброжение комбинации
            label_bank_sum.Text = GameController.Bank.ToString(); //Обновили информацию о текущем состоянии банка(кона)

            card_replacement.Visible = false;  //Убираем панель

            btn_new_game.Text = GameController.Bank > 0 ? "Забрать банк" : "Пробовать снова";

            btn_new_game.Visible = true; //Показываем кнопку Продолжить


        }

        private void GameStateDistribution() //Начальное cостояние игры 
        {
            SelectedButtons.Clear();//Убрали выбранные кнопки
            btn_card_1.BorderStyle = BorderStyle.None;
            btn_card_2.BorderStyle = BorderStyle.None;
            btn_card_3.BorderStyle = BorderStyle.None;
            btn_card_4.BorderStyle = BorderStyle.None;
            btn_card_5.BorderStyle = BorderStyle.None;

            balance.Text = GameController.Player?.Balance.ToString(); //Обновить баланс

            groupBoxChips.Visible = true; //Показали поле ввода ставки
            label_bet_text.Visible = true; //Показали поле ввода ставки

            btn_new_game.Visible = false; //Убрали кнопку Продолжить

            panelBankLabel.Visible = false; //Показали банк
            card_replacement.Visible = false; //Показали банк

            input_money.Text = ""; //Очистили поле ввода ставки
            label_combo.Text = ""; //Очистили комбинации

        }




        private void restartGame(object sender, EventArgs e) //Кнопка завершить игру
        {
            //Финализируем
            GameController.FinishCurrentGame(); //Вернуть в исходное состояние серверную часть 
            GameStateDistribution();//Вернуться в исходное состояние графику
        }



        //Сдесь хранятся карты, которые мы выбрали для замены

        enum Btn { Card_1, Card_2, Card_3, Card_4, Card_5 };

        private IDictionary<Btn, Action> SelectedButtons = new Dictionary<Btn, Action>();

        private void btn_card_select(Btn card, PictureBox btn, Action action)
        {
            if (SelectedButtons.ContainsKey(card)) //Если эта карты была нажата, то убираем ее
            {
                btn.BorderStyle = BorderStyle.None;
                SelectedButtons.Remove(card);
            }
            else
            {
                btn.BorderStyle = BorderStyle.Fixed3D;
                SelectedButtons.Add(card, action);
            }
        }


        private void btn_card_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox btn)
            {
                if (btn == btn_card_1) btn_card_select(Btn.Card_1, btn, GameController.ChangeCard_1);
                else if (btn == btn_card_2) btn_card_select(Btn.Card_2, btn, GameController.ChangeCard_2);
                else if (btn == btn_card_3) btn_card_select(Btn.Card_3, btn, GameController.ChangeCard_3);
                else if (btn == btn_card_4) btn_card_select(Btn.Card_4, btn, GameController.ChangeCard_4);
                else if (btn == btn_card_5) btn_card_select(Btn.Card_5, btn, GameController.ChangeCard_5);

            }
        }

        private void btn_select_all_card_Click(object sender, EventArgs e)
        {
            SelectedButtons.Clear();
            SelectedButtons.Add(Btn.Card_1, GameController.ChangeCard_1);
            SelectedButtons.Add(Btn.Card_2, GameController.ChangeCard_2);
            SelectedButtons.Add(Btn.Card_3, GameController.ChangeCard_3);
            SelectedButtons.Add(Btn.Card_4, GameController.ChangeCard_4);
            SelectedButtons.Add(Btn.Card_5, GameController.ChangeCard_5);

            btn_card_1.BorderStyle = BorderStyle.Fixed3D;
            btn_card_2.BorderStyle = BorderStyle.Fixed3D;
            btn_card_3.BorderStyle = BorderStyle.Fixed3D;
            btn_card_4.BorderStyle = BorderStyle.Fixed3D;
            btn_card_5.BorderStyle = BorderStyle.Fixed3D;

        }

        private void btn_repeat_bet_Click(object sender, EventArgs e)
        {
            input_money.Text = GameController.PreviousBet.ToString();
        }
    }
}
