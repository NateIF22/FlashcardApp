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
            tbContext = new TextBox();
            lblQuestion = new Label();
            lblFront = new Label();
            SuspendLayout();
            // 
            // tbContext
            // 
            tbContext.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbContext.BorderStyle = BorderStyle.FixedSingle;
            tbContext.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbContext.Location = new Point(27, 141);
            tbContext.Multiline = true;
            tbContext.Name = "tbContext";
            tbContext.ReadOnly = true;
            tbContext.Size = new Size(320, 206);
            tbContext.TabIndex = 2;
            tbContext.Text = "Possible context for the word or question goes here.";
            tbContext.TextAlign = HorizontalAlignment.Center;
            // 
            // lblQuestion
            // 
            lblQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(0, 54);
            lblQuestion.MaximumSize = new Size(377, 0);
            lblQuestion.MinimumSize = new Size(377, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(377, 31);
            lblQuestion.TabIndex = 3;
            lblQuestion.Text = "Word/Question";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFront
            // 
            lblFront.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblFront.AutoSize = true;
            lblFront.BorderStyle = BorderStyle.FixedSingle;
            lblFront.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFront.Location = new Point(3, 14);
            lblFront.MaximumSize = new Size(371, 31);
            lblFront.MinimumSize = new Size(371, 31);
            lblFront.Name = "lblFront";
            lblFront.Size = new Size(371, 31);
            lblFront.TabIndex = 4;
            lblFront.Text = "Front";
            lblFront.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CardFrontControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(lblFront);
            Controls.Add(lblQuestion);
            Controls.Add(tbContext);
            Name = "CardFrontControl";
            Size = new Size(377, 465);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbContext;
        private Label lblQuestion;
        private Label lblFront;
    }
}
