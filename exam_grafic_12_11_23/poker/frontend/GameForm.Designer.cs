

using poker.backend;
using poker.frontend;

namespace poker
{
    internal partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            button2 = new Button();
            panel1 = new PanelEnhanced();
            btn_change_cards = new Button();
            tableLayoutPanelPrice = new TableLayoutPanel();
            btn_select_all_card = new Button();
            label_combo = new Label();
            panelBankLabel = new Panel();
            initial_bid = new Label();
            label1 = new Label();
            label_bank_sum = new Label();
            label_bank_text = new Label();
            btn_new_game = new Button();
            btn_card_5 = new PictureBox();
            btn_card_4 = new PictureBox();
            btn_card_3 = new PictureBox();
            btn_card_2 = new PictureBox();
            btn_card_1 = new PictureBox();
            card_replacement = new GroupBox();
            btn_finish_game = new Button();
            groupBoxChips = new GroupBox();
            btn_chip_2 = new Button();
            btn_chip_x2 = new Button();
            btn_repeat_bet = new Button();
            label3 = new Label();
            btn_chip_vabank = new Button();
            input_money = new TextBox();
            btn_chip_100000 = new Button();
            btn_chip_20000 = new Button();
            btn_chip_5000 = new Button();
            btn_chip_1000 = new Button();
            button3 = new Button();
            btn_chip_100 = new Button();
            btn_chip_500 = new Button();
            label_bet_text = new Label();
            btn_exit = new Button();
            button1 = new Button();
            balance = new Label();
            ScoreLabel = new Label();
            panel1.SuspendLayout();
            panelBankLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_card_5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_card_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_card_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_card_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_card_1).BeginInit();
            card_replacement.SuspendLayout();
            groupBoxChips.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(1548, 9);
            button2.Name = "button2";
            button2.Size = new Size(137, 50);
            button2.TabIndex = 14;
            button2.Text = "Выход";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btn_exit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btn_change_cards);
            panel1.Controls.Add(tableLayoutPanelPrice);
            panel1.Controls.Add(btn_select_all_card);
            panel1.Controls.Add(label_combo);
            panel1.Controls.Add(panelBankLabel);
            panel1.Controls.Add(btn_new_game);
            panel1.Controls.Add(btn_card_5);
            panel1.Controls.Add(btn_card_4);
            panel1.Controls.Add(btn_card_3);
            panel1.Controls.Add(btn_card_2);
            panel1.Controls.Add(btn_card_1);
            panel1.Controls.Add(card_replacement);
            panel1.Controls.Add(groupBoxChips);
            panel1.Controls.Add(label_bet_text);
            panel1.Controls.Add(btn_exit);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(balance);
            panel1.Controls.Add(ScoreLabel);
            panel1.Location = new Point(-9, -44);
            panel1.Name = "panel1";
            panel1.Size = new Size(1441, 946);
            panel1.TabIndex = 15;
            // 
            // btn_change_cards
            // 
            btn_change_cards.Cursor = Cursors.Hand;
            btn_change_cards.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_change_cards.Location = new Point(715, 841);
            btn_change_cards.Name = "btn_change_cards";
            btn_change_cards.Size = new Size(244, 68);
            btn_change_cards.TabIndex = 1;
            btn_change_cards.Text = "Поменять";
            btn_change_cards.UseVisualStyleBackColor = true;
            btn_change_cards.Click += btn_change_cards_Click;
            // 
            // tableLayoutPanelPrice
            // 
            tableLayoutPanelPrice.BackColor = Color.Transparent;
            tableLayoutPanelPrice.ColumnCount = 2;
            tableLayoutPanelPrice.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanelPrice.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanelPrice.Location = new Point(13, 166);
            tableLayoutPanelPrice.Name = "tableLayoutPanelPrice";
            tableLayoutPanelPrice.RowCount = 9;
            tableLayoutPanelPrice.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelPrice.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelPrice.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelPrice.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelPrice.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelPrice.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelPrice.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelPrice.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelPrice.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelPrice.Size = new Size(352, 454);
            tableLayoutPanelPrice.TabIndex = 56;
            // 
            // btn_select_all_card
            // 
            btn_select_all_card.Cursor = Cursors.Hand;
            btn_select_all_card.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_select_all_card.Location = new Point(516, 851);
            btn_select_all_card.Name = "btn_select_all_card";
            btn_select_all_card.Size = new Size(193, 58);
            btn_select_all_card.TabIndex = 55;
            btn_select_all_card.Text = "Выбрать все";
            btn_select_all_card.UseVisualStyleBackColor = true;
            btn_select_all_card.Click += btn_select_all_card_Click;
            // 
            // label_combo
            // 
            label_combo.AutoSize = true;
            label_combo.Font = new Font("XO Courser", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label_combo.ForeColor = SystemColors.ButtonFace;
            label_combo.Location = new Point(473, 590);
            label_combo.Name = "label_combo";
            label_combo.Size = new Size(0, 30);
            label_combo.TabIndex = 54;
            // 
            // panelBankLabel
            // 
            panelBankLabel.BackColor = Color.Transparent;
            panelBankLabel.Controls.Add(initial_bid);
            panelBankLabel.Controls.Add(label1);
            panelBankLabel.Controls.Add(label_bank_sum);
            panelBankLabel.Controls.Add(label_bank_text);
            panelBankLabel.Location = new Point(532, 319);
            panelBankLabel.Name = "panelBankLabel";
            panelBankLabel.Size = new Size(455, 110);
            panelBankLabel.TabIndex = 53;
            panelBankLabel.Visible = false;
            // 
            // initial_bid
            // 
            initial_bid.AutoSize = true;
            initial_bid.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            initial_bid.ForeColor = SystemColors.ButtonFace;
            initial_bid.ImageAlign = ContentAlignment.TopCenter;
            initial_bid.Location = new Point(165, 3);
            initial_bid.Name = "initial_bid";
            initial_bid.Size = new Size(30, 36);
            initial_bid.TabIndex = 26;
            initial_bid.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 25;
            label1.Text = "Начал. ставка:";
            // 
            // label_bank_sum
            // 
            label_bank_sum.AutoSize = true;
            label_bank_sum.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label_bank_sum.ForeColor = SystemColors.ButtonFace;
            label_bank_sum.Location = new Point(165, 67);
            label_bank_sum.Name = "label_bank_sum";
            label_bank_sum.Size = new Size(30, 36);
            label_bank_sum.TabIndex = 24;
            label_bank_sum.Text = "0";
            // 
            // label_bank_text
            // 
            label_bank_text.AutoSize = true;
            label_bank_text.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_bank_text.ForeColor = SystemColors.ButtonFace;
            label_bank_text.Location = new Point(0, 76);
            label_bank_text.Name = "label_bank_text";
            label_bank_text.Size = new Size(143, 25);
            label_bank_text.TabIndex = 23;
            label_bank_text.Text = "Текущий банк:";
            // 
            // btn_new_game
            // 
            btn_new_game.Cursor = Cursors.Hand;
            btn_new_game.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btn_new_game.Location = new Point(1062, 728);
            btn_new_game.Name = "btn_new_game";
            btn_new_game.Size = new Size(294, 98);
            btn_new_game.TabIndex = 52;
            btn_new_game.Text = "Забрать банк";
            btn_new_game.UseVisualStyleBackColor = true;
            btn_new_game.Visible = false;
            btn_new_game.Click += restartGame;
            // 
            // btn_card_5
            // 
            btn_card_5.BackColor = Color.Transparent;
            btn_card_5.Cursor = Cursors.Hand;
            btn_card_5.Location = new Point(756, 638);
            btn_card_5.Name = "btn_card_5";
            btn_card_5.Size = new Size(112, 186);
            btn_card_5.TabIndex = 51;
            btn_card_5.TabStop = false;
            btn_card_5.Click += btn_card_Click;
            // 
            // btn_card_4
            // 
            btn_card_4.BackColor = Color.Transparent;
            btn_card_4.Cursor = Cursors.Hand;
            btn_card_4.Location = new Point(629, 638);
            btn_card_4.Name = "btn_card_4";
            btn_card_4.Size = new Size(112, 186);
            btn_card_4.TabIndex = 50;
            btn_card_4.TabStop = false;
            btn_card_4.Click += btn_card_Click;
            // 
            // btn_card_3
            // 
            btn_card_3.BackColor = Color.Transparent;
            btn_card_3.Cursor = Cursors.Hand;
            btn_card_3.Location = new Point(508, 638);
            btn_card_3.Name = "btn_card_3";
            btn_card_3.Size = new Size(112, 186);
            btn_card_3.TabIndex = 49;
            btn_card_3.TabStop = false;
            btn_card_3.Click += btn_card_Click;
            // 
            // btn_card_2
            // 
            btn_card_2.BackColor = Color.Transparent;
            btn_card_2.Cursor = Cursors.Hand;
            btn_card_2.Location = new Point(383, 638);
            btn_card_2.Name = "btn_card_2";
            btn_card_2.Size = new Size(112, 186);
            btn_card_2.TabIndex = 48;
            btn_card_2.TabStop = false;
            btn_card_2.Click += btn_card_Click;
            // 
            // btn_card_1
            // 
            btn_card_1.BackColor = Color.Transparent;
            btn_card_1.Cursor = Cursors.Hand;
            btn_card_1.Location = new Point(246, 638);
            btn_card_1.Name = "btn_card_1";
            btn_card_1.Size = new Size(119, 186);
            btn_card_1.TabIndex = 47;
            btn_card_1.TabStop = false;
            btn_card_1.Click += btn_card_Click;
            // 
            // card_replacement
            // 
            card_replacement.BackColor = Color.Transparent;
            card_replacement.Controls.Add(btn_finish_game);
            card_replacement.Location = new Point(980, 501);
            card_replacement.Name = "card_replacement";
            card_replacement.Size = new Size(448, 408);
            card_replacement.TabIndex = 46;
            card_replacement.TabStop = false;
            card_replacement.Visible = false;
            // 
            // btn_finish_game
            // 
            btn_finish_game.Cursor = Cursors.Hand;
            btn_finish_game.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_finish_game.Location = new Point(76, 137);
            btn_finish_game.Name = "btn_finish_game";
            btn_finish_game.Size = new Size(305, 68);
            btn_finish_game.TabIndex = 0;
            btn_finish_game.Text = "Завершить игру";
            btn_finish_game.UseVisualStyleBackColor = true;
            btn_finish_game.Click += restartGame;
            // 
            // groupBoxChips
            // 
            groupBoxChips.Controls.Add(btn_chip_2);
            groupBoxChips.Controls.Add(btn_chip_x2);
            groupBoxChips.Controls.Add(btn_repeat_bet);
            groupBoxChips.Controls.Add(label3);
            groupBoxChips.Controls.Add(btn_chip_vabank);
            groupBoxChips.Controls.Add(input_money);
            groupBoxChips.Controls.Add(btn_chip_100000);
            groupBoxChips.Controls.Add(btn_chip_20000);
            groupBoxChips.Controls.Add(btn_chip_5000);
            groupBoxChips.Controls.Add(btn_chip_1000);
            groupBoxChips.Controls.Add(button3);
            groupBoxChips.Controls.Add(btn_chip_100);
            groupBoxChips.Controls.Add(btn_chip_500);
            groupBoxChips.Location = new Point(980, 501);
            groupBoxChips.Name = "groupBoxChips";
            groupBoxChips.Size = new Size(448, 408);
            groupBoxChips.TabIndex = 45;
            groupBoxChips.TabStop = false;
            // 
            // btn_chip_2
            // 
            btn_chip_2.Cursor = Cursors.Hand;
            btn_chip_2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btn_chip_2.Location = new Point(355, 249);
            btn_chip_2.Name = "btn_chip_2";
            btn_chip_2.Size = new Size(75, 56);
            btn_chip_2.TabIndex = 30;
            btn_chip_2.Text = "\\2";
            btn_chip_2.UseVisualStyleBackColor = true;
            btn_chip_2.Click += btn_chip_Click;
            // 
            // btn_chip_x2
            // 
            btn_chip_x2.Cursor = Cursors.Hand;
            btn_chip_x2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btn_chip_x2.Location = new Point(278, 249);
            btn_chip_x2.Name = "btn_chip_x2";
            btn_chip_x2.Size = new Size(71, 56);
            btn_chip_x2.TabIndex = 29;
            btn_chip_x2.Text = "X2";
            btn_chip_x2.UseVisualStyleBackColor = true;
            btn_chip_x2.Click += btn_chip_Click;
            // 
            // btn_repeat_bet
            // 
            btn_repeat_bet.Cursor = Cursors.Hand;
            btn_repeat_bet.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_repeat_bet.Location = new Point(7, 322);
            btn_repeat_bet.Name = "btn_repeat_bet";
            btn_repeat_bet.Size = new Size(194, 80);
            btn_repeat_bet.TabIndex = 28;
            btn_repeat_bet.Text = "Повторить";
            btn_repeat_bet.UseVisualStyleBackColor = true;
            btn_repeat_bet.Click += btn_repeat_bet_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(7, 27);
            label3.Name = "label3";
            label3.Size = new Size(101, 36);
            label3.TabIndex = 2;
            label3.Text = "Ставка:";
            // 
            // btn_chip_vabank
            // 
            btn_chip_vabank.Cursor = Cursors.Hand;
            btn_chip_vabank.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_chip_vabank.Location = new Point(9, 249);
            btn_chip_vabank.Name = "btn_chip_vabank";
            btn_chip_vabank.Size = new Size(260, 56);
            btn_chip_vabank.TabIndex = 27;
            btn_chip_vabank.Text = "Va-Bank";
            btn_chip_vabank.UseVisualStyleBackColor = true;
            btn_chip_vabank.Click += btn_chip_Click;
            // 
            // input_money
            // 
            input_money.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            input_money.Location = new Point(114, 20);
            input_money.Name = "input_money";
            input_money.Size = new Size(325, 47);
            input_money.TabIndex = 1;
            // 
            // btn_chip_100000
            // 
            btn_chip_100000.Cursor = Cursors.Hand;
            btn_chip_100000.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_chip_100000.Location = new Point(311, 175);
            btn_chip_100000.Name = "btn_chip_100000";
            btn_chip_100000.Size = new Size(128, 68);
            btn_chip_100000.TabIndex = 26;
            btn_chip_100000.Text = "100 000";
            btn_chip_100000.UseVisualStyleBackColor = true;
            btn_chip_100000.Click += btn_chip_Click;
            // 
            // btn_chip_20000
            // 
            btn_chip_20000.Cursor = Cursors.Hand;
            btn_chip_20000.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_chip_20000.Location = new Point(160, 175);
            btn_chip_20000.Name = "btn_chip_20000";
            btn_chip_20000.Size = new Size(129, 68);
            btn_chip_20000.TabIndex = 25;
            btn_chip_20000.Text = "20 000";
            btn_chip_20000.UseVisualStyleBackColor = true;
            btn_chip_20000.Click += btn_chip_Click;
            // 
            // btn_chip_5000
            // 
            btn_chip_5000.Cursor = Cursors.Hand;
            btn_chip_5000.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_chip_5000.Location = new Point(7, 175);
            btn_chip_5000.Name = "btn_chip_5000";
            btn_chip_5000.Size = new Size(136, 68);
            btn_chip_5000.TabIndex = 24;
            btn_chip_5000.Text = "5000";
            btn_chip_5000.UseVisualStyleBackColor = true;
            btn_chip_5000.Click += btn_chip_Click;
            // 
            // btn_chip_1000
            // 
            btn_chip_1000.Cursor = Cursors.Hand;
            btn_chip_1000.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_chip_1000.Location = new Point(311, 89);
            btn_chip_1000.Name = "btn_chip_1000";
            btn_chip_1000.Size = new Size(128, 68);
            btn_chip_1000.TabIndex = 23;
            btn_chip_1000.Text = "1000";
            btn_chip_1000.UseVisualStyleBackColor = true;
            btn_chip_1000.Click += btn_chip_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(207, 322);
            button3.Name = "button3";
            button3.Size = new Size(223, 80);
            button3.TabIndex = 15;
            button3.Text = "Сделать ставку";
            button3.UseVisualStyleBackColor = true;
            button3.Click += place_a_bet_Click;
            // 
            // btn_chip_100
            // 
            btn_chip_100.Cursor = Cursors.Hand;
            btn_chip_100.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_chip_100.Location = new Point(7, 89);
            btn_chip_100.Name = "btn_chip_100";
            btn_chip_100.Size = new Size(136, 68);
            btn_chip_100.TabIndex = 20;
            btn_chip_100.Text = "100";
            btn_chip_100.UseVisualStyleBackColor = true;
            btn_chip_100.Click += btn_chip_Click;
            // 
            // btn_chip_500
            // 
            btn_chip_500.Cursor = Cursors.Hand;
            btn_chip_500.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_chip_500.Location = new Point(160, 90);
            btn_chip_500.Name = "btn_chip_500";
            btn_chip_500.Size = new Size(129, 67);
            btn_chip_500.TabIndex = 21;
            btn_chip_500.Text = "500";
            btn_chip_500.UseVisualStyleBackColor = true;
            btn_chip_500.Click += btn_chip_Click;
            // 
            // label_bet_text
            // 
            label_bet_text.AutoSize = true;
            label_bet_text.BackColor = Color.Transparent;
            label_bet_text.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label_bet_text.ForeColor = SystemColors.ButtonFace;
            label_bet_text.Location = new Point(508, 256);
            label_bet_text.Name = "label_bet_text";
            label_bet_text.Size = new Size(360, 60);
            label_bet_text.TabIndex = 41;
            label_bet_text.Text = "Сделайте ставку";
            // 
            // btn_exit
            // 
            btn_exit.Cursor = Cursors.Hand;
            btn_exit.Location = new Point(1258, 44);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(123, 61);
            btn_exit.TabIndex = 44;
            btn_exit.Text = "Выход";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(21, 44);
            button1.Name = "button1";
            button1.Size = new Size(130, 43);
            button1.TabIndex = 43;
            button1.Text = "Завершить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btn_back_Click;
            // 
            // balance
            // 
            balance.AutoSize = true;
            balance.BackColor = Color.Transparent;
            balance.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            balance.ForeColor = SystemColors.ButtonFace;
            balance.Location = new Point(258, 35);
            balance.Name = "balance";
            balance.Size = new Size(35, 41);
            balance.TabIndex = 42;
            balance.Text = "0";
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.BackColor = Color.Transparent;
            ScoreLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            ScoreLabel.ForeColor = SystemColors.ButtonFace;
            ScoreLabel.Location = new Point(172, 33);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(88, 41);
            ScoreLabel.TabIndex = 40;
            ScoreLabel.Text = "счет:";
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(154, 201, 192);
            BackgroundImageLayout = ImageLayout.Stretch;
            CausesValidation = false;
            ClientSize = new Size(1421, 893);
            Controls.Add(panel1);
            Controls.Add(button2);
            Name = "GameForm";
            Text = "GameForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelBankLabel.ResumeLayout(false);
            panelBankLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_card_5).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_card_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_card_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_card_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_card_1).EndInit();
            card_replacement.ResumeLayout(false);
            groupBoxChips.ResumeLayout(false);
            groupBoxChips.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private TableLayoutPanel tableLayoutPanelPrice;
        private Button btn_select_all_card;
        private Label label_combo;
        private Panel panelBankLabel;
        private Label initial_bid;
        private Label label1;
        private Label label_bank_sum;
        private Label label_bank_text;
        private Button btn_new_game;
        private PictureBox btn_card_5;
        private PictureBox btn_card_4;
        private PictureBox btn_card_3;
        private PictureBox btn_card_2;
        private PictureBox btn_card_1;
        private GroupBox card_replacement;
        private Button btn_change_cards;
        private Button btn_finish_game;
        private GroupBox groupBoxChips;
        private Button btn_chip_2;
        private Button btn_chip_x2;
        private Button btn_repeat_bet;
        private Label label3;
        private Button btn_chip_vabank;
        private TextBox input_money;
        private Button btn_chip_100000;
        private Button btn_chip_20000;
        private Button btn_chip_5000;
        private Button btn_chip_1000;
        private Button button3;
        private Button btn_chip_100;
        private Button btn_chip_500;
        private Label label_bet_text;
        private Button btn_exit;
        private Button button1;
        private Label balance;
        private Label ScoreLabel;
        private PanelEnhanced panel1;
    }
}