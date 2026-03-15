namespace FinalFormApp
{
    partial class CardEditForm
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
            gbCardFront = new GroupBox();
            tbQuestionNote = new TextBox();
            lblQuestionNote = new Label();
            tbQuestion = new TextBox();
            lblQuestion = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            gbCardBack = new GroupBox();
            tbAnswerNote = new TextBox();
            lblAnswerNote = new Label();
            tbAnswer = new TextBox();
            lblAnswer = new Label();
            gbCardFront.SuspendLayout();
            gbCardBack.SuspendLayout();
            SuspendLayout();
            // 
            // gbCardFront
            // 
            gbCardFront.Controls.Add(tbQuestionNote);
            gbCardFront.Controls.Add(lblQuestionNote);
            gbCardFront.Controls.Add(tbQuestion);
            gbCardFront.Controls.Add(lblQuestion);
            gbCardFront.Location = new Point(12, 12);
            gbCardFront.Name = "gbCardFront";
            gbCardFront.Size = new Size(298, 99);
            gbCardFront.TabIndex = 0;
            gbCardFront.TabStop = false;
            gbCardFront.Text = "Card Front";
            // 
            // tbQuestionNote
            // 
            tbQuestionNote.Location = new Point(106, 59);
            tbQuestionNote.Name = "tbQuestionNote";
            tbQuestionNote.PlaceholderText = "(optional)";
            tbQuestionNote.Size = new Size(175, 27);
            tbQuestionNote.TabIndex = 5;
            // 
            // lblQuestionNote
            // 
            lblQuestionNote.AutoSize = true;
            lblQuestionNote.Location = new Point(33, 62);
            lblQuestionNote.Name = "lblQuestionNote";
            lblQuestionNote.Size = new Size(42, 20);
            lblQuestionNote.TabIndex = 4;
            lblQuestionNote.Text = "Note";
            // 
            // tbQuestion
            // 
            tbQuestion.Location = new Point(106, 26);
            tbQuestion.Name = "tbQuestion";
            tbQuestion.PlaceholderText = "Guten Abend";
            tbQuestion.Size = new Size(175, 27);
            tbQuestion.TabIndex = 3;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(7, 29);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(68, 20);
            lblQuestion.TabIndex = 2;
            lblQuestion.Text = "Question";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(199, 227);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(27, 227);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // gbCardBack
            // 
            gbCardBack.Controls.Add(tbAnswerNote);
            gbCardBack.Controls.Add(lblAnswerNote);
            gbCardBack.Controls.Add(tbAnswer);
            gbCardBack.Controls.Add(lblAnswer);
            gbCardBack.Location = new Point(12, 117);
            gbCardBack.Name = "gbCardBack";
            gbCardBack.Size = new Size(298, 104);
            gbCardBack.TabIndex = 10;
            gbCardBack.TabStop = false;
            gbCardBack.Text = "Card Back";
            // 
            // tbAnswerNote
            // 
            tbAnswerNote.Location = new Point(106, 59);
            tbAnswerNote.Name = "tbAnswerNote";
            tbAnswerNote.PlaceholderText = "(optional)";
            tbAnswerNote.Size = new Size(175, 27);
            tbAnswerNote.TabIndex = 5;
            // 
            // lblAnswerNote
            // 
            lblAnswerNote.AutoSize = true;
            lblAnswerNote.Location = new Point(33, 62);
            lblAnswerNote.Name = "lblAnswerNote";
            lblAnswerNote.Size = new Size(42, 20);
            lblAnswerNote.TabIndex = 4;
            lblAnswerNote.Text = "Note";
            // 
            // tbAnswer
            // 
            tbAnswer.Location = new Point(106, 26);
            tbAnswer.Name = "tbAnswer";
            tbAnswer.PlaceholderText = "Good Morning";
            tbAnswer.Size = new Size(175, 27);
            tbAnswer.TabIndex = 3;
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Location = new Point(18, 29);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(57, 20);
            lblAnswer.TabIndex = 2;
            lblAnswer.Text = "Answer";
            // 
            // CardEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 268);
            Controls.Add(gbCardBack);
            Controls.Add(gbCardFront);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "CardEditForm";
            Text = "CardEditForm";
            Load += CardEditForm_Load;
            gbCardFront.ResumeLayout(false);
            gbCardFront.PerformLayout();
            gbCardBack.ResumeLayout(false);
            gbCardBack.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbCardFront;
        private Button btnSave;
        private Button btnCancel;
        private TextBox tbQuestionNote;
        private Label lblQuestionNote;
        private TextBox tbQuestion;
        private Label lblQuestion;
        private GroupBox gbCardBack;
        private TextBox tbAnswerNote;
        private Label lblAnswerNote;
        private TextBox tbAnswer;
        private Label lblAnswer;
    }
}