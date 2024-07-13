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
            dgData = new DataGridView();
            BtnOk = new Button();
            ((System.ComponentModel.ISupportInitialize)dgData).BeginInit();
            SuspendLayout();
            // 
            // dgData
            // 
            dgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgData.Location = new Point(12, 25);
            dgData.Name = "dgData";
            dgData.Size = new Size(523, 220);
            dgData.TabIndex = 0;
            // 
            // BtnOk
            // 
            BtnOk.Location = new Point(232, 339);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(75, 23);
            BtnOk.TabIndex = 1;
            BtnOk.Text = "Ок";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnOk);
            Controls.Add(dgData);
            Name = "Authorization";
            Text = "Form1";
            Load += Authorization_Load;
            ((System.ComponentModel.ISupportInitialize)dgData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgData;
        private Button BtnOk;
    }
}