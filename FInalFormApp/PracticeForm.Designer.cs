namespace FinalFormApp
{
    partial class PracticeForm
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
            btnExit = new Button();
            btnFlip = new Button();
            btnCorrect = new Button();
            btnIncorrect = new Button();
            cardBackControl = new CardBackControl();
            cardFrontControl = new CardFrontControl();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.Location = new Point(12, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(164, 58);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnFlip
            // 
            btnFlip.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnFlip.Location = new Point(286, 393);
            btnFlip.Name = "btnFlip";
            btnFlip.Size = new Size(164, 58);
            btnFlip.TabIndex = 4;
            btnFlip.Text = "Flip";
            btnFlip.UseVisualStyleBackColor = true;
            btnFlip.Click += btnFlip_Click;
            // 
            // btnCorrect
            // 
            btnCorrect.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCorrect.AutoSize = true;
            btnCorrect.BackColor = Color.LimeGreen;
            btnCorrect.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCorrect.Location = new Point(556, 369);
            btnCorrect.Name = "btnCorrect";
            btnCorrect.Size = new Size(164, 58);
            btnCorrect.TabIndex = 5;
            btnCorrect.Text = "Correct";
            btnCorrect.UseVisualStyleBackColor = false;
            btnCorrect.Click += btnCorrect_Click;
            // 
            // btnIncorrect
            // 
            btnIncorrect.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnIncorrect.AutoSize = true;
            btnIncorrect.BackColor = Color.OrangeRed;
            btnIncorrect.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncorrect.Location = new Point(556, 433);
            btnIncorrect.Name = "btnIncorrect";
            btnIncorrect.Size = new Size(164, 58);
            btnIncorrect.TabIndex = 6;
            btnIncorrect.Text = "Incorrect";
            btnIncorrect.UseVisualStyleBackColor = false;
            btnIncorrect.Click += btnIncorrect_Click;
            // 
            // cardBackControl
            // 
            cardBackControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cardBackControl.BackColor = SystemColors.Control;
            cardBackControl.BorderStyle = BorderStyle.FixedSingle;
            cardBackControl.Location = new Point(182, 12);
            cardBackControl.Name = "cardBackControl";
            cardBackControl.Size = new Size(371, 479);
            cardBackControl.TabIndex = 2;
            // 
            // cardFrontControl
            // 
            cardFrontControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cardFrontControl.BackColor = SystemColors.Control;
            cardFrontControl.BorderStyle = BorderStyle.FixedSingle;
            cardFrontControl.Location = new Point(182, 12);
            cardFrontControl.MinimumSize = new Size(371, 0);
            cardFrontControl.Name = "cardFrontControl";
            cardFrontControl.Size = new Size(371, 479);
            cardFrontControl.TabIndex = 3;
            // 
            // PracticeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 503);
            Controls.Add(cardFrontControl);
            Controls.Add(cardBackControl);
            Controls.Add(btnIncorrect);
            Controls.Add(btnCorrect);
            Controls.Add(btnFlip);
            Controls.Add(btnExit);
            MinimumSize = new Size(750, 550);
            Name = "PracticeForm";
            Text = "Practice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnFlip;
        private Button btnCorrect;
        private Button btnIncorrect;
        private CardBackControl cardBackControl;
        private CardFrontControl cardFrontControl;
    }
}