namespace Coldi
{
    partial class ToDoListForm
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
            tasksListBox = new ListBox();
            addBTN = new Button();
            WriteTaskTextBox = new TextBox();
            DeleteBTN = new Button();
            СhangeBTN = new Button();
            label1 = new Label();
            ChangeBox = new TextBox();
            CloseBTN = new Button();
            executionListBox = new ListBox();
            executionBTN = new Button();
            SuspendLayout();
            // 
            // tasksListBox
            // 
            tasksListBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tasksListBox.FormattingEnabled = true;
            tasksListBox.ItemHeight = 15;
            tasksListBox.Location = new Point(12, 121);
            tasksListBox.Name = "tasksListBox";
            tasksListBox.Size = new Size(365, 319);
            tasksListBox.TabIndex = 0;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(12, 92);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(75, 23);
            addBTN.TabIndex = 1;
            addBTN.Text = "Add";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // WriteTaskTextBox
            // 
            WriteTaskTextBox.Location = new Point(113, 27);
            WriteTaskTextBox.Name = "WriteTaskTextBox";
            WriteTaskTextBox.Size = new Size(100, 23);
            WriteTaskTextBox.TabIndex = 2;
            // 
            // DeleteBTN
            // 
            DeleteBTN.Location = new Point(93, 92);
            DeleteBTN.Name = "DeleteBTN";
            DeleteBTN.Size = new Size(75, 23);
            DeleteBTN.TabIndex = 3;
            DeleteBTN.Text = " Delete";
            DeleteBTN.UseVisualStyleBackColor = true;
            DeleteBTN.Click += DeleteBTN_Click;
            // 
            // СhangeBTN
            // 
            СhangeBTN.Location = new Point(174, 92);
            СhangeBTN.Name = "СhangeBTN";
            СhangeBTN.Size = new Size(75, 23);
            СhangeBTN.TabIndex = 0;
            СhangeBTN.Text = "To change";
            СhangeBTN.UseVisualStyleBackColor = true;
            СhangeBTN.Click += СhangeBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 27);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 5;
            label1.Text = "Напишите задачу";
            // 
            // ChangeBox
            // 
            ChangeBox.BorderStyle = BorderStyle.FixedSingle;
            ChangeBox.Location = new Point(163, 148);
            ChangeBox.Name = "ChangeBox";
            ChangeBox.Size = new Size(100, 23);
            ChangeBox.TabIndex = 6;
            ChangeBox.Visible = false;
            // 
            // CloseBTN
            // 
            CloseBTN.BackColor = Color.Red;
            CloseBTN.FlatStyle = FlatStyle.Popup;
            CloseBTN.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CloseBTN.Location = new Point(461, 12);
            CloseBTN.Name = "CloseBTN";
            CloseBTN.Size = new Size(47, 38);
            CloseBTN.TabIndex = 7;
            CloseBTN.Text = "X";
            CloseBTN.UseVisualStyleBackColor = false;
            CloseBTN.Click += CloseBTN_Click;
            // 
            // executionListBox
            // 
            executionListBox.FormattingEnabled = true;
            executionListBox.ItemHeight = 15;
            executionListBox.Location = new Point(257, 121);
            executionListBox.Name = "executionListBox";
            executionListBox.Size = new Size(120, 319);
            executionListBox.TabIndex = 8;
            // 
            // executionBTN
            // 
            executionBTN.Location = new Point(383, 121);
            executionBTN.Name = "executionBTN";
            executionBTN.Size = new Size(75, 23);
            executionBTN.TabIndex = 9;
            executionBTN.Text = "Notice";
            executionBTN.UseVisualStyleBackColor = true;
            executionBTN.Click += executionBTN_Click;
            // 
            // ToDoListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 479);
            Controls.Add(executionBTN);
            Controls.Add(ChangeBox);
            Controls.Add(executionListBox);
            Controls.Add(CloseBTN);
            Controls.Add(СhangeBTN);
            Controls.Add(label1);
            Controls.Add(DeleteBTN);
            Controls.Add(WriteTaskTextBox);
            Controls.Add(addBTN);
            Controls.Add(tasksListBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ToDoListForm";
            Text = "ToDoListForm";
            Load += ToDoListForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox tasksListBox;
        private Button addBTN;
        private TextBox WriteTaskTextBox;
        private Button DeleteBTN;
        private Label label1;
        private Button СhangeBTN;
        private TextBox ChangeBox;
        private Button CloseBTN;
        private ListBox executionListBox;
        private Button executionBTN;
    }
}