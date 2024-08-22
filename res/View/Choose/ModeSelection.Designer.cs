namespace Coldi
{
    partial class ModeSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModeSelection));
            PlayBTN = new Button();
            label1 = new Label();
            ProgramsBTN = new Button();
            nameUser = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            BackBTN = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BackBTN).BeginInit();
            SuspendLayout();
            // 
            // PlayBTN
            // 
            PlayBTN.BackColor = Color.DarkBlue;
            PlayBTN.FlatAppearance.MouseOverBackColor = Color.DarkBlue;
            PlayBTN.FlatStyle = FlatStyle.Popup;
            PlayBTN.Font = new Font("Segoe UI Semilight", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PlayBTN.ForeColor = Color.White;
            PlayBTN.Location = new Point(306, 266);
            PlayBTN.Name = "PlayBTN";
            PlayBTN.Size = new Size(557, 105);
            PlayBTN.TabIndex = 0;
            PlayBTN.Text = "Plays";
            PlayBTN.UseVisualStyleBackColor = false;
            PlayBTN.Click += PlayBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 63.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(226, 9);
            label1.Name = "label1";
            label1.Size = new Size(734, 226);
            label1.TabIndex = 1;
            label1.Text = "Choose what you \r\n want to explone";
            // 
            // ProgramsBTN
            // 
            ProgramsBTN.BackColor = Color.FromArgb(192, 64, 0);
            ProgramsBTN.FlatStyle = FlatStyle.Popup;
            ProgramsBTN.Font = new Font("Segoe UI Semilight", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ProgramsBTN.ForeColor = Color.White;
            ProgramsBTN.Location = new Point(306, 430);
            ProgramsBTN.Name = "ProgramsBTN";
            ProgramsBTN.Size = new Size(557, 105);
            ProgramsBTN.TabIndex = 2;
            ProgramsBTN.Text = "Programs";
            ProgramsBTN.UseVisualStyleBackColor = false;
            ProgramsBTN.Click += ProgramsBTN_Click;
            // 
            // nameUser
            // 
            nameUser.AutoSize = true;
            nameUser.BackColor = Color.Transparent;
            nameUser.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameUser.ForeColor = Color.White;
            nameUser.Location = new Point(1036, 9);
            nameUser.Name = "nameUser";
            nameUser.Size = new Size(123, 59);
            nameUser.TabIndex = 3;
            nameUser.Text = "Uber";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(327, 275);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += PlayBTN_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DarkBlue;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(738, 275);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 86);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(192, 64, 0);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(327, 439);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 86);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += ProgramsBTN_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(192, 64, 0);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(738, 439);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 86);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            pictureBox4.Click += ProgramsBTN_Click;
            // 
            // BackBTN
            // 
            BackBTN.BackColor = Color.Transparent;
            BackBTN.Image = (Image)resources.GetObject("BackBTN.Image");
            BackBTN.Location = new Point(30, 597);
            BackBTN.Name = "BackBTN";
            BackBTN.Size = new Size(94, 94);
            BackBTN.SizeMode = PictureBoxSizeMode.AutoSize;
            BackBTN.TabIndex = 8;
            BackBTN.TabStop = false;
            BackBTN.Click += BackBTN_Click;
            // 
            // ModeSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1181, 703);
            Controls.Add(BackBTN);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(nameUser);
            Controls.Add(ProgramsBTN);
            Controls.Add(label1);
            Controls.Add(PlayBTN);
            Name = "ModeSelection";
            Text = "Coldi";
            Load += ModeSelection_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)BackBTN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PlayBTN;
        private Label label1;
        private Button ProgramsBTN;
        private Label nameUser;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox BackBTN;
    }
}