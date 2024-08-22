namespace Coldi
{
    partial class AsagoForm
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
            самарскаяОбластьToolStripMenuItem = new ToolStripMenuItem();
            RegComboBox = new ComboBox();
            CityComboBox = new ComboBox();
            resultBTN = new Button();
            ScoreKof = new Label();
            label1 = new Label();
            label2 = new Label();
            AgeTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            kofAge_and_Experience = new Label();
            label5 = new Label();
            ExperienceTextBox = new TextBox();
            limitedRadioButton = new RadioButton();
            unlimitedRadioButton = new RadioButton();
            label6 = new Label();
            label7 = new Label();
            kofDrivers = new Label();
            label8 = new Label();
            kofKMB = new Label();
            kofPower = new Label();
            PowerTextBox = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label9 = new Label();
            TransportСategoryСomboBox = new ComboBox();
            RateLabel = new Label();
            label13 = new Label();
            resultLabel = new Label();
            label14 = new Label();
            SuspendLayout();
            // 
            // самарскаяОбластьToolStripMenuItem
            // 
            самарскаяОбластьToolStripMenuItem.Name = "самарскаяОбластьToolStripMenuItem";
            самарскаяОбластьToolStripMenuItem.Size = new Size(213, 22);
            самарскаяОбластьToolStripMenuItem.Text = "Самарская область";
            // 
            // RegComboBox
            // 
            RegComboBox.AutoCompleteCustomSource.AddRange(new string[] { "Ульяновская область", "Пензанская область", "Самарская область", "Республика Башкортостан", "Республика Татарстан" });
            RegComboBox.FormattingEnabled = true;
            RegComboBox.Items.AddRange(new object[] { "Ульяновская область", "Самарская область", "Пензенская область", "Республика Башкортостан", "Республика Татарстан" });
            RegComboBox.Location = new Point(12, 33);
            RegComboBox.Name = "RegComboBox";
            RegComboBox.Size = new Size(158, 23);
            RegComboBox.TabIndex = 2;
            RegComboBox.SelectedIndexChanged += RegComboBox_SelectedIndexChanged;
            // 
            // CityComboBox
            // 
            CityComboBox.FormattingEnabled = true;
            CityComboBox.Location = new Point(169, 55);
            CityComboBox.Name = "CityComboBox";
            CityComboBox.Size = new Size(121, 23);
            CityComboBox.TabIndex = 3;
            CityComboBox.Visible = false;
            CityComboBox.SelectedIndexChanged += CityComboBox_SelectedIndexChanged;
            // 
            // resultBTN
            // 
            resultBTN.BackColor = Color.LimeGreen;
            resultBTN.FlatStyle = FlatStyle.Popup;
            resultBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            resultBTN.Location = new Point(660, 396);
            resultBTN.Name = "resultBTN";
            resultBTN.Size = new Size(111, 42);
            resultBTN.TabIndex = 4;
            resultBTN.Text = "Обработать";
            resultBTN.UseVisualStyleBackColor = false;
            resultBTN.Click += resultBTN_Click;
            // 
            // ScoreKof
            // 
            ScoreKof.BackColor = Color.LightGray;
            ScoreKof.ForeColor = Color.Black;
            ScoreKof.Location = new Point(107, 70);
            ScoreKof.Name = "ScoreKof";
            ScoreKof.Size = new Size(46, 15);
            ScoreKof.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 69);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 6;
            label1.Text = "Коэффициент:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(237, 15);
            label2.TabIndex = 7;
            label2.Text = "Выберите регион и город проживания:";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(351, 40);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(100, 23);
            AgeTextBox.TabIndex = 8;
            AgeTextBox.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 44);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 9;
            label3.Text = "Ваш возраст:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(255, 69);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 11;
            label4.Text = "Коэффициент:";
            // 
            // kofAge_and_Experience
            // 
            kofAge_and_Experience.BackColor = Color.LightGray;
            kofAge_and_Experience.ForeColor = Color.Black;
            kofAge_and_Experience.Location = new Point(353, 70);
            kofAge_and_Experience.Name = "kofAge_and_Experience";
            kofAge_and_Experience.Size = new Size(46, 15);
            kofAge_and_Experience.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(281, 12);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 13;
            label5.Text = "Ваш стаж:";
            // 
            // ExperienceTextBox
            // 
            ExperienceTextBox.Location = new Point(351, 9);
            ExperienceTextBox.Name = "ExperienceTextBox";
            ExperienceTextBox.Size = new Size(100, 23);
            ExperienceTextBox.TabIndex = 12;
            ExperienceTextBox.Text = "0";
            // 
            // limitedRadioButton
            // 
            limitedRadioButton.AutoSize = true;
            limitedRadioButton.Checked = true;
            limitedRadioButton.Location = new Point(558, 32);
            limitedRadioButton.Name = "limitedRadioButton";
            limitedRadioButton.Size = new Size(95, 19);
            limitedRadioButton.TabIndex = 14;
            limitedRadioButton.TabStop = true;
            limitedRadioButton.Text = "Ограничено";
            limitedRadioButton.UseVisualStyleBackColor = true;
            // 
            // unlimitedRadioButton
            // 
            unlimitedRadioButton.AutoSize = true;
            unlimitedRadioButton.Location = new Point(558, 57);
            unlimitedRadioButton.Name = "unlimitedRadioButton";
            unlimitedRadioButton.Size = new Size(109, 19);
            unlimitedRadioButton.TabIndex = 15;
            unlimitedRadioButton.Text = "Неограничено";
            unlimitedRadioButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(486, 96);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 16;
            label6.Text = "Коэффициент:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(476, 10);
            label7.Name = "label7";
            label7.Size = new Size(148, 15);
            label7.TabIndex = 17;
            label7.Text = "Количество водителей: ";
            // 
            // kofDrivers
            // 
            kofDrivers.BackColor = Color.LightGray;
            kofDrivers.ForeColor = Color.Black;
            kofDrivers.Location = new Point(578, 96);
            kofDrivers.Name = "kofDrivers";
            kofDrivers.Size = new Size(46, 15);
            kofDrivers.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(660, 12);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 19;
            label8.Text = "Ваш КМБ:";
            // 
            // kofKMB
            // 
            kofKMB.BackColor = Color.LightGray;
            kofKMB.ForeColor = Color.Black;
            kofKMB.Location = new Point(725, 12);
            kofKMB.Name = "kofKMB";
            kofKMB.Size = new Size(46, 15);
            kofKMB.TabIndex = 20;
            // 
            // kofPower
            // 
            kofPower.BackColor = Color.LightGray;
            kofPower.ForeColor = Color.Black;
            kofPower.Location = new Point(111, 166);
            kofPower.Name = "kofPower";
            kofPower.Size = new Size(46, 15);
            kofPower.TabIndex = 23;
            // 
            // PowerTextBox
            // 
            PowerTextBox.Location = new Point(109, 136);
            PowerTextBox.Name = "PowerTextBox";
            PowerTextBox.Size = new Size(100, 23);
            PowerTextBox.TabIndex = 21;
            PowerTextBox.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 165);
            label10.Name = "label10";
            label10.Size = new Size(92, 15);
            label10.TabIndex = 24;
            label10.Text = "Коэффициент:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(22, 140);
            label11.Name = "label11";
            label11.Size = new Size(71, 15);
            label11.TabIndex = 22;
            label11.Text = "Мощность:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(246, 136);
            label9.Name = "label9";
            label9.Size = new Size(244, 15);
            label9.TabIndex = 25;
            label9.Text = "Тип и категория транспортного средства:";
            // 
            // TransportСategoryСomboBox
            // 
            TransportСategoryСomboBox.FormattingEnabled = true;
            TransportСategoryСomboBox.Items.AddRange(new object[] { "Мотоциклы, мотороллеры (категории А)", "Легковые автомобили(категории B)", "Грузовые автомобили(категории C)" });
            TransportСategoryСomboBox.Location = new Point(301, 163);
            TransportСategoryСomboBox.Name = "TransportСategoryСomboBox";
            TransportСategoryСomboBox.Size = new Size(189, 23);
            TransportСategoryСomboBox.TabIndex = 26;
            // 
            // RateLabel
            // 
            RateLabel.BackColor = Color.LightGray;
            RateLabel.ForeColor = Color.Black;
            RateLabel.Location = new Point(583, 139);
            RateLabel.Name = "RateLabel";
            RateLabel.Size = new Size(70, 15);
            RateLabel.TabIndex = 28;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(531, 140);
            label13.Name = "label13";
            label13.Size = new Size(46, 15);
            label13.TabIndex = 27;
            label13.Text = "Тариф:";
            // 
            // resultLabel
            // 
            resultLabel.BackColor = Color.LightGray;
            resultLabel.ForeColor = Color.Black;
            resultLabel.Location = new Point(141, 238);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(98, 15);
            resultLabel.TabIndex = 30;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(22, 238);
            label14.Name = "label14";
            label14.Size = new Size(113, 15);
            label14.TabIndex = 29;
            label14.Text = "Стоимость ОСАГО:";
            // 
            // AsagoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(label14);
            Controls.Add(RateLabel);
            Controls.Add(label13);
            Controls.Add(TransportСategoryСomboBox);
            Controls.Add(label9);
            Controls.Add(kofPower);
            Controls.Add(PowerTextBox);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(kofKMB);
            Controls.Add(label8);
            Controls.Add(kofDrivers);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(unlimitedRadioButton);
            Controls.Add(limitedRadioButton);
            Controls.Add(label5);
            Controls.Add(ExperienceTextBox);
            Controls.Add(kofAge_and_Experience);
            Controls.Add(AgeTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ScoreKof);
            Controls.Add(resultBTN);
            Controls.Add(CityComboBox);
            Controls.Add(RegComboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "AsagoForm";
            Text = "AsagoForm";
            Load += AsagoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem самарскаяОбластьToolStripMenuItem;
        private ComboBox RegComboBox;
        private ComboBox CityComboBox;
        private Button resultBTN;
        private Label ScoreKof;
        private Label label1;
        private Label label2;
        private TextBox AgeTextBox;
        private Label label3;
        private Label label4;
        private Label kofAge_and_Experience;
        private Label label5;
        private TextBox ExperienceTextBox;
        private RadioButton limitedRadioButton;
        private RadioButton unlimitedRadioButton;
        private Label label6;
        private Label label7;
        private Label kofDrivers;
        private Label label8;
        private Label kofKMB;
        private Label kofPower;
        private TextBox PowerTextBox;
        private Label label10;
        private Label label11;
        private Label label9;
        private ComboBox TransportСategoryСomboBox;
        private Label RateLabel;
        private Label label13;
        private Label resultLabel;
        private Label label14;
    }
}