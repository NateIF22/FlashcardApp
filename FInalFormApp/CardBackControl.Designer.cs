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
            lblBack = new Label();
            SuspendLayout();
            // 
            // tbContext
            // 
            tbContext.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbContext.Location = new Point(15, 155);
            tbContext.Multiline = true;
            tbContext.Name = "tbContext";
            tbContext.ReadOnly = true;
            tbContext.Size = new Size(346, 187);
            tbContext.TabIndex = 2;
            tbContext.Text = "Possible context for the answer goes here.";
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnswer.Location = new Point(105, 86);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(153, 31);
            lblAnswer.TabIndex = 3;
            lblAnswer.Text = "Word/Answer";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBack.Location = new Point(152, 21);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(65, 31);
            lblBack.TabIndex = 4;
            lblBack.Text = "Back";
            // 
            // CardBackControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(lblBack);
            Controls.Add(lblAnswer);
            Controls.Add(tbContext);
            Name = "CardBackControl";
            Size = new Size(377, 465);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbContext;
        private Label lblAnswer;
        private Label lblBack;
    }
}
