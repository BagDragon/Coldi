namespace Coldi
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Log_in = new Button();
            loginBox = new TextBox();
            passwordBox = new TextBox();
            unregistered = new Label();
            Back = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Light", 63.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(203, 192);
            label1.Name = "label1";
            label1.Size = new Size(245, 113);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Light", 63.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(85, 342);
            label2.Name = "label2";
            label2.Size = new Size(378, 113);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 69.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(238, 33);
            label3.Name = "label3";
            label3.Size = new Size(652, 108);
            label3.TabIndex = 2;
            label3.Text = "Authorization";
            // 
            // Log_in
            // 
            Log_in.BackColor = Color.FromArgb(192, 0, 0);
            Log_in.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            Log_in.FlatAppearance.BorderSize = 0;
            Log_in.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            Log_in.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            Log_in.FlatStyle = FlatStyle.Flat;
            Log_in.Font = new Font("Segoe UI Light", 48F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Log_in.ForeColor = Color.White;
            Log_in.Location = new Point(391, 543);
            Log_in.Name = "Log_in";
            Log_in.Size = new Size(405, 97);
            Log_in.TabIndex = 3;
            Log_in.Text = "Log in";
            Log_in.UseVisualStyleBackColor = false;
            Log_in.Click += Log_in_Click;
            // 
            // loginBox
            // 
            loginBox.BackColor = Color.Silver;
            loginBox.BorderStyle = BorderStyle.None;
            loginBox.Font = new Font("Segoe UI", 54.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginBox.ForeColor = Color.White;
            loginBox.Location = new Point(450, 213);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(422, 98);
            loginBox.TabIndex = 4;
            // 
            // passwordBox
            // 
            passwordBox.BackColor = Color.Silver;
            passwordBox.BorderStyle = BorderStyle.None;
            passwordBox.Font = new Font("Segoe UI", 54.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passwordBox.ForeColor = Color.White;
            passwordBox.Location = new Point(450, 357);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(422, 98);
            passwordBox.TabIndex = 5;
            // 
            // unregistered
            // 
            unregistered.AutoSize = true;
            unregistered.BackColor = Color.Transparent;
            unregistered.Font = new Font("Segoe UI Semilight", 20.25F, FontStyle.Underline, GraphicsUnit.Point, 204);
            unregistered.ForeColor = Color.Navy;
            unregistered.Location = new Point(391, 500);
            unregistered.Name = "unregistered";
            unregistered.Size = new Size(400, 37);
            unregistered.TabIndex = 6;
            unregistered.Text = "Click here if you are unregistered";
            unregistered.Click += unregistered_Click;
            // 
            // Back
            // 
            Back.BackColor = Color.Transparent;
            Back.BackgroundImage = (Image)resources.GetObject("Back.BackgroundImage");
            Back.FlatAppearance.BorderSize = 0;
            Back.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Back.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Location = new Point(25, 566);
            Back.Name = "Back";
            Back.Size = new Size(94, 92);
            Back.TabIndex = 7;
            Back.UseVisualStyleBackColor = false;
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1181, 670);
            Controls.Add(Back);
            Controls.Add(unregistered);
            Controls.Add(passwordBox);
            Controls.Add(loginBox);
            Controls.Add(Log_in);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Authorization";
            Text = "Coldi";
            Load += Authorization_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button Log_in;
        private TextBox loginBox;
        private TextBox passwordBox;
        private Label unregistered;
        private Button Back;
    }
}