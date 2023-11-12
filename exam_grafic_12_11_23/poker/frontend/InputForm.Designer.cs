using poker.backend;
using poker.frontend;
using System.Windows.Forms;

namespace poker
{
    partial class InputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            mainPanel = new PanelEnhanced();
            tableLayoutPanel1 = new TableLayoutPanel();
            label_record = new Label();
            btn_exit2 = new Button();
            btn_new_player = new Button();
            input_name = new TextBox();
            labelName = new Label();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackgroundImage = (Image)resources.GetObject("mainPanel.BackgroundImage");
            mainPanel.BackgroundImageLayout = ImageLayout.Stretch;
            mainPanel.Controls.Add(tableLayoutPanel1);
            mainPanel.Controls.Add(label_record);
            mainPanel.Controls.Add(btn_exit2);
            mainPanel.Controls.Add(btn_new_player);
            mainPanel.Controls.Add(input_name);
            mainPanel.Controls.Add(labelName);
            mainPanel.Location = new Point(-3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1395, 864);
            mainPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tableLayoutPanel1.Location = new Point(15, 194);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Size = new Size(937, 657);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // label_record
            // 
            label_record.AutoSize = true;
            label_record.BackColor = Color.Transparent;
            label_record.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label_record.ForeColor = Color.Coral;
            label_record.Location = new Point(28, 95);
            label_record.Name = "label_record";
            label_record.Size = new Size(128, 36);
            label_record.TabIndex = 10;
            label_record.Text = "Рекорды";
            // 
            // btn_exit2
            // 
            btn_exit2.BackColor = Color.Bisque;
            btn_exit2.Cursor = Cursors.Hand;
            btn_exit2.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_exit2.Location = new Point(1253, 13);
            btn_exit2.Name = "btn_exit2";
            btn_exit2.Size = new Size(127, 47);
            btn_exit2.TabIndex = 9;
            btn_exit2.Text = "Выход";
            btn_exit2.UseVisualStyleBackColor = false;
            btn_exit2.Click += BtnExitClick;
            // 
            // btn_new_player
            // 
            btn_new_player.Cursor = Cursors.Hand;
            btn_new_player.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_new_player.Location = new Point(970, 345);
            btn_new_player.Name = "btn_new_player";
            btn_new_player.Size = new Size(399, 100);
            btn_new_player.TabIndex = 8;
            btn_new_player.Text = "Создать игрока";
            btn_new_player.UseVisualStyleBackColor = true;
            btn_new_player.Click += BtnCreateUser;
            // 
            // input_name
            // 
            input_name.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            input_name.Location = new Point(970, 263);
            input_name.Name = "input_name";
            input_name.Size = new Size(398, 61);
            input_name.TabIndex = 7;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Transparent;
            labelName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.ForeColor = SystemColors.Control;
            labelName.Location = new Point(1027, 194);
            labelName.Name = "labelName";
            labelName.Size = new Size(268, 41);
            labelName.TabIndex = 6;
            labelName.Text = "Введите ваше имя";
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1389, 862);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InputForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label_record;
        private Button btn_exit2;
        private Button btn_new_player;
        private TextBox input_name;
        private Label labelName;
    }
}