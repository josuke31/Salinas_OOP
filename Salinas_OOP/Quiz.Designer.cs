namespace Salinas_OOP
{
    partial class Quiz
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
            label1 = new Label();
            label2 = new Label();
            lblQuestion = new Label();
            btnAns1 = new Button();
            btnAns2 = new Button();
            btnAns3 = new Button();
            btnAns4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 32);
            label1.TabIndex = 0;
            label1.Text = "Quiz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(108, 30);
            label2.TabIndex = 1;
            label2.Text = "Question:";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblQuestion.Location = new Point(131, 93);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(53, 18);
            lblQuestion.TabIndex = 2;
            lblQuestion.Text = "label3";
            lblQuestion.Click += lblQuestion_Click;
            // 
            // btnAns1
            // 
            btnAns1.BackColor = SystemColors.ButtonFace;
            btnAns1.FlatStyle = FlatStyle.Popup;
            btnAns1.Location = new Point(161, 192);
            btnAns1.Name = "btnAns1";
            btnAns1.Size = new Size(191, 72);
            btnAns1.TabIndex = 3;
            btnAns1.Text = "Answer1";
            btnAns1.UseVisualStyleBackColor = false;
            btnAns1.Click += button1_Click;
            // 
            // btnAns2
            // 
            btnAns2.BackColor = SystemColors.ButtonFace;
            btnAns2.FlatStyle = FlatStyle.Popup;
            btnAns2.Location = new Point(406, 192);
            btnAns2.Name = "btnAns2";
            btnAns2.Size = new Size(191, 72);
            btnAns2.TabIndex = 4;
            btnAns2.Text = "Answer2";
            btnAns2.UseVisualStyleBackColor = false;
            // 
            // btnAns3
            // 
            btnAns3.BackColor = SystemColors.ButtonFace;
            btnAns3.FlatStyle = FlatStyle.Popup;
            btnAns3.Location = new Point(161, 285);
            btnAns3.Name = "btnAns3";
            btnAns3.Size = new Size(191, 72);
            btnAns3.TabIndex = 5;
            btnAns3.Text = "Answer3";
            btnAns3.UseVisualStyleBackColor = false;
            // 
            // btnAns4
            // 
            btnAns4.BackColor = SystemColors.ButtonFace;
            btnAns4.FlatStyle = FlatStyle.Popup;
            btnAns4.Location = new Point(406, 285);
            btnAns4.Name = "btnAns4";
            btnAns4.Size = new Size(191, 72);
            btnAns4.TabIndex = 6;
            btnAns4.Text = "Answer4";
            btnAns4.UseVisualStyleBackColor = false;
            // 
            // Quiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(779, 393);
            Controls.Add(btnAns4);
            Controls.Add(btnAns3);
            Controls.Add(btnAns2);
            Controls.Add(btnAns1);
            Controls.Add(lblQuestion);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(795, 432);
            MinimumSize = new Size(795, 432);
            Name = "Quiz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblQuestion;
        private Button btnAns1;
        private Button btnAns2;
        private Button btnAns3;
        private Button btnAns4;
    }
}