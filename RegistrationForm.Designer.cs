﻿namespace Coldi
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            label1 = new Label();
            label2 = new Label();
            loginBox = new TextBox();
            RegBTN = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            BackBTN = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BackBTN).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 69.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(302, 3);
            label1.Name = "label1";
            label1.Size = new Size(562, 124);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Light", 48F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(279, 146);
            label2.Name = "label2";
            label2.Size = new Size(185, 86);
            label2.TabIndex = 1;
            label2.Text = "Login";
            // 
            // loginBox
            // 
            loginBox.BackColor = Color.Silver;
            loginBox.BorderStyle = BorderStyle.None;
            loginBox.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginBox.ForeColor = Color.White;
            loginBox.Location = new Point(471, 161);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(422, 71);
            loginBox.TabIndex = 2;
            // 
            // RegBTN
            // 
            RegBTN.BackColor = Color.FromArgb(206, 67, 67);
            RegBTN.FlatStyle = FlatStyle.Popup;
            RegBTN.Font = new Font("Segoe UI Semilight", 48F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RegBTN.ForeColor = Color.White;
            RegBTN.Location = new Point(379, 577);
            RegBTN.Name = "RegBTN";
            RegBTN.Size = new Size(405, 97);
            RegBTN.TabIndex = 3;
            RegBTN.Text = " Register";
            RegBTN.UseVisualStyleBackColor = false;
            RegBTN.Click += RegBTN_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Light", 39.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(54, 469);
            label3.Name = "label3";
            label3.Size = new Size(410, 71);
            label3.TabIndex = 4;
            label3.Text = "Repeat password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Light", 48F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(179, 356);
            label4.Name = "label4";
            label4.Size = new Size(286, 86);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Light", 48F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.White;
            label5.Location = new Point(259, 255);
            label5.Name = "label5";
            label5.Size = new Size(205, 86);
            label5.TabIndex = 6;
            label5.Text = "E-mail";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Silver;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(471, 368);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(422, 71);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Silver;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(471, 469);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(422, 71);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Silver;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(471, 267);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(422, 71);
            textBox3.TabIndex = 9;
            // 
            // BackBTN
            // 
            BackBTN.BackColor = Color.Transparent;
            BackBTN.Image = (Image)resources.GetObject("BackBTN.Image");
            BackBTN.Location = new Point(24, 597);
            BackBTN.Name = "BackBTN";
            BackBTN.Size = new Size(94, 94);
            BackBTN.SizeMode = PictureBoxSizeMode.AutoSize;
            BackBTN.TabIndex = 10;
            BackBTN.TabStop = false;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1181, 703);
            Controls.Add(BackBTN);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(RegBTN);
            Controls.Add(loginBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrationForm";
            Text = "Coldi";
            Load += RegistrationForm_Load;
            ((System.ComponentModel.ISupportInitialize)BackBTN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox loginBox;
        private Button RegBTN;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private PictureBox BackBTN;
    }
}