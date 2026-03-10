namespace FinalFormApp
{
    partial class CardFrontControl
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
            lblTitle = new Label();
            btnFlip = new Button();
            tbContext = new TextBox();
            lblQuestion = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(148, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(75, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // btnFlip
            // 
            btnFlip.Location = new Point(133, 397);
            btnFlip.Name = "btnFlip";
            btnFlip.Size = new Size(110, 29);
            btnFlip.TabIndex = 1;
            btnFlip.Text = "Flip";
            btnFlip.UseVisualStyleBackColor = true;
            // 
            // tbContext
            // 
            tbContext.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbContext.Location = new Point(53, 171);
            tbContext.Multiline = true;
            tbContext.Name = "tbContext";
            tbContext.ReadOnly = true;
            tbContext.Size = new Size(270, 121);
            tbContext.TabIndex = 2;
            tbContext.Text = "Possible context for the word or question goes here.";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(103, 119);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(170, 31);
            lblQuestion.TabIndex = 3;
            lblQuestion.Text = "Word/Question";
            // 
            // Card
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblQuestion);
            Controls.Add(tbContext);
            Controls.Add(btnFlip);
            Controls.Add(lblTitle);
            Name = "Card";
            Size = new Size(377, 465);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnFlip;
        private TextBox tbContext;
        private Label lblQuestion;
    }
}
