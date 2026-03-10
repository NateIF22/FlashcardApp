namespace FinalFormApp
{
    partial class CardBackControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbContext = new TextBox();
            lblAnswer = new Label();
            btnCorrect = new Button();
            btnIncorrect = new Button();
            SuspendLayout();
            // 
            // tbContext
            // 
            tbContext.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbContext.Location = new Point(48, 159);
            tbContext.Multiline = true;
            tbContext.Name = "tbContext";
            tbContext.ReadOnly = true;
            tbContext.Size = new Size(270, 121);
            tbContext.TabIndex = 2;
            tbContext.Text = "Possible context for the answer goes here.";
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnswer.Location = new Point(103, 88);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(170, 31);
            lblAnswer.TabIndex = 3;
            lblAnswer.Text = "Word/Question";
            // 
            // btnCorrect
            // 
            btnCorrect.Location = new Point(224, 386);
            btnCorrect.Name = "btnCorrect";
            btnCorrect.Size = new Size(94, 29);
            btnCorrect.TabIndex = 4;
            btnCorrect.Text = "Correct";
            btnCorrect.UseVisualStyleBackColor = true;
            // 
            // btnIncorrect
            // 
            btnIncorrect.Location = new Point(48, 386);
            btnIncorrect.Name = "btnIncorrect";
            btnIncorrect.Size = new Size(94, 29);
            btnIncorrect.TabIndex = 5;
            btnIncorrect.Text = "Incorrect";
            btnIncorrect.UseVisualStyleBackColor = true;
            // 
            // CardBack
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnIncorrect);
            Controls.Add(btnCorrect);
            Controls.Add(lblAnswer);
            Controls.Add(tbContext);
            Name = "CardBack";
            Size = new Size(377, 465);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbContext;
        private Label lblAnswer;
        private Button btnCorrect;
        private Button btnIncorrect;
    }
}
