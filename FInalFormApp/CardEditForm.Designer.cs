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
            btnSave = new Button();
            btnCancel = new Button();
            textBox3 = new TextBox();
            lblQuestionContext = new Label();
            textBox2 = new TextBox();
            lblQuestion = new Label();
            textBox1 = new TextBox();
            lblName = new Label();
            gbCardBack = new GroupBox();
            textBox5 = new TextBox();
            lblAnswerContext = new Label();
            textBox6 = new TextBox();
            lblAnswer = new Label();
            gbCardFront.SuspendLayout();
            gbCardBack.SuspendLayout();
            SuspendLayout();
            // 
            // gbCardFront
            // 
            gbCardFront.Controls.Add(textBox3);
            gbCardFront.Controls.Add(lblQuestionContext);
            gbCardFront.Controls.Add(textBox2);
            gbCardFront.Controls.Add(lblQuestion);
            gbCardFront.Controls.Add(textBox1);
            gbCardFront.Controls.Add(lblName);
            gbCardFront.Location = new Point(12, 12);
            gbCardFront.Name = "gbCardFront";
            gbCardFront.Size = new Size(298, 129);
            gbCardFront.TabIndex = 0;
            gbCardFront.TabStop = false;
            gbCardFront.Text = "Card Front";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(199, 257);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(27, 257);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(106, 86);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(175, 27);
            textBox3.TabIndex = 5;
            // 
            // lblQuestionContext
            // 
            lblQuestionContext.AutoSize = true;
            lblQuestionContext.Location = new Point(15, 89);
            lblQuestionContext.Name = "lblQuestionContext";
            lblQuestionContext.Size = new Size(60, 20);
            lblQuestionContext.TabIndex = 4;
            lblQuestionContext.Text = "Context";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(106, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 27);
            textBox2.TabIndex = 3;
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(7, 56);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(68, 20);
            lblQuestion.TabIndex = 2;
            lblQuestion.Text = "Question";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 27);
            textBox1.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(26, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // gbCardBack
            // 
            gbCardBack.Controls.Add(textBox5);
            gbCardBack.Controls.Add(lblAnswerContext);
            gbCardBack.Controls.Add(textBox6);
            gbCardBack.Controls.Add(lblAnswer);
            gbCardBack.Location = new Point(12, 147);
            gbCardBack.Name = "gbCardBack";
            gbCardBack.Size = new Size(298, 104);
            gbCardBack.TabIndex = 10;
            gbCardBack.TabStop = false;
            gbCardBack.Text = "Card Back";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(106, 59);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(175, 27);
            textBox5.TabIndex = 5;
            // 
            // lblAnswerContext
            // 
            lblAnswerContext.AutoSize = true;
            lblAnswerContext.Location = new Point(15, 62);
            lblAnswerContext.Name = "lblAnswerContext";
            lblAnswerContext.Size = new Size(60, 20);
            lblAnswerContext.TabIndex = 4;
            lblAnswerContext.Text = "Context";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(106, 26);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(175, 27);
            textBox6.TabIndex = 3;
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
            ClientSize = new Size(323, 297);
            Controls.Add(gbCardBack);
            Controls.Add(gbCardFront);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "CardEditForm";
            Text = "CardEditForm";
            gbCardFront.ResumeLayout(false);
            gbCardFront.PerformLayout();
            gbCardBack.ResumeLayout(false);
            gbCardBack.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbCardFront;
        private Label lblName;
        private Button btnSave;
        private Button btnCancel;
        private TextBox textBox3;
        private Label lblQuestionContext;
        private TextBox textBox2;
        private Label lblQuestion;
        private TextBox textBox1;
        private GroupBox gbCardBack;
        private TextBox textBox5;
        private Label lblAnswerContext;
        private TextBox textBox6;
        private Label lblAnswer;
    }
}