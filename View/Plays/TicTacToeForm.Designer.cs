namespace Coldi
{
    partial class TicTacToeForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            reset = new Button();
            stroke = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(100, 100);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(128, 12);
            button2.Name = "button2";
            button2.Size = new Size(100, 100);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(243, 12);
            button3.Name = "button3";
            button3.Size = new Size(100, 100);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 130);
            button4.Name = "button4";
            button4.Size = new Size(100, 100);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            // 
            // button5
            // 
            button5.Location = new Point(128, 130);
            button5.Name = "button5";
            button5.Size = new Size(100, 100);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button1_Click;
            // 
            // button6
            // 
            button6.Location = new Point(243, 130);
            button6.Name = "button6";
            button6.Size = new Size(100, 100);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button1_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 246);
            button7.Name = "button7";
            button7.Size = new Size(100, 100);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button1_Click;
            // 
            // button8
            // 
            button8.Location = new Point(128, 246);
            button8.Name = "button8";
            button8.Size = new Size(100, 100);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button1_Click;
            // 
            // button9
            // 
            button9.Location = new Point(243, 245);
            button9.Name = "button9";
            button9.Size = new Size(100, 100);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button1_Click;
            // 
            // reset
            // 
            reset.Location = new Point(365, 169);
            reset.Name = "reset";
            reset.Size = new Size(75, 23);
            reset.TabIndex = 9;
            reset.Text = "Заново";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // stroke
            // 
            stroke.AutoSize = true;
            stroke.Location = new Point(349, 27);
            stroke.Name = "stroke";
            stroke.Size = new Size(59, 15);
            stroke.TabIndex = 10;
            stroke.Text = "Stroke: X";
            // 
            // TicTacToeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 358);
            Controls.Add(stroke);
            Controls.Add(reset);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "TicTacToeForm";
            Text = "TicTacToeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button reset;
        private Label stroke;
    }
}