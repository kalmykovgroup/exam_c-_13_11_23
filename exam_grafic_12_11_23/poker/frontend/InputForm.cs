
using Microsoft.VisualBasic.ApplicationServices;
using poker.backend;
using poker.frontend;
using System.Numerics;
using System.Windows.Forms;

namespace poker
{
    internal partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();

            int j = 0;
            tableLayoutPanel1.RowCount = 10;
            foreach (var player in GameController.Players)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));

                List<Label> labels = new List<Label>();

                for (int i = 0; i < 3; i++) //i[0] - ID | i[1] - Name | i[2] - Record
                {
                    labels.Add(new Label());
                }


                for (int i = 0; i < 3; i++) //i[0] - ID | i[1] - Name | i[2] - Record
                {
                    labels[i].AutoSize = true;
                    labels[i].BackColor = Color.Transparent;
                    labels[i].Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
                    labels[i].ForeColor = Color.Coral;
                }

                labels[0].Text = player.Id.ToString();
                labels[1].Text = player.Name.ToString();
                labels[2].Text = $"рекорд: {player.Record}\n" + $"баланс: {player.Balance}";

                Button btn = new Button();

                btn.Text = $"Играть";
                btn.Name = $"User_{player.Id}";
                btn.Cursor = Cursors.Hand;
                btn.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
                btn.Size = new Size(127, 47);
                btn.UseVisualStyleBackColor = true;

                btn.Click += ClickUser;


                tableLayoutPanel1.Controls.Add(labels[0], 0, j);
                tableLayoutPanel1.Controls.Add(labels[1], 1, j);
                tableLayoutPanel1.Controls.Add(labels[2], 2, j);
                tableLayoutPanel1.Controls.Add(btn, 3, j);

                j++;
            }


        }



        private void BtnExit(object sender, EventArgs e) => FormController.ExitApp();

        private void BtnCreateUser(object sender, EventArgs e) //Вызов, когда мы создаем игрока
        {
            if (sender is Button btn && btn == btn_new_player)
            {
                if (input_name.Text.Length == 0) return;

                FormController.ActionGame(new Player(input_name.Text));

                if (this == FormController.MainForm) Hide();
                else Close();

            }

        }

        private void BtnStartMouseLeave(object sender, EventArgs e) => ((Button)sender).BackColor = Color.White;

        private void BtnStartMouseMove(object sender, EventArgs e) => ((Button)sender).BackColor = Color.PeachPuff;


        private void ClickUser(object sender, EventArgs e) //Кнопка выбрать игрока
        {
            if (sender is Button btn)
            {
                foreach (var player in GameController.Players)
                {
                    if (btn.Name == $"User_{player.Id}")
                    {
                        FormController.ActionGame(player);
                        if (this == FormController.MainForm) Hide();
                        else Close();
                        return;
                    }
                }

            }

        }

        private void BtnExitClick(object sender, EventArgs e)
        {
            FormController.ExitApp();
        }


    }
}
