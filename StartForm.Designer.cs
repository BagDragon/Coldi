namespace Coldi
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StartBTN = new Button();
            SuspendLayout();
            // 
            // StartBTN
            // 
            StartBTN.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            StartBTN.BackColor = Color.Transparent;
            StartBTN.FlatAppearance.BorderSize = 0;
            StartBTN.FlatAppearance.MouseDownBackColor = Color.Transparent;
            StartBTN.FlatAppearance.MouseOverBackColor = Color.Transparent;
            StartBTN.Font = new Font("Segoe UI Symbol", 39.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartBTN.ForeColor = Color.White;
            StartBTN.Location = new Point(505, 585);
            StartBTN.Name = "StartBTN";
            StartBTN.Size = new Size(216, 83);
            StartBTN.TabIndex = 0;
            StartBTN.Text = "Start";
            StartBTN.UseVisualStyleBackColor = false;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1181, 703);
            Controls.Add(StartBTN);
            MaximumSize = new Size(1197, 742);
            MinimumSize = new Size(1197, 742);
            Name = "StartForm";
            Text = "Coldi";
            ResumeLayout(false);
        }

        #endregion

        private Button StartBTN;
    }
}
