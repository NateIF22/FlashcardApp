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
            cardFrontControl = new CardFrontControl();
            cardBackControl = new CardBackControl();
            btnFlip = new Button();
            btnCorrect = new Button();
            btnIncorrect = new Button();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(164, 58);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // cardFrontControl
            // 
            cardFrontControl.BackColor = SystemColors.ControlDark;
            cardFrontControl.Location = new Point(182, 35);
            cardFrontControl.Name = "cardFrontControl";
            cardFrontControl.Size = new Size(368, 440);
            cardFrontControl.TabIndex = 2;
            // 
            // cardBackControl
            // 
            cardBackControl.BackColor = SystemColors.ControlDark;
            cardBackControl.Location = new Point(182, 35);
            cardBackControl.Name = "cardBackControl";
            cardBackControl.Size = new Size(368, 440);
            cardBackControl.TabIndex = 3;
            // 
            // btnFlip
            // 
            btnFlip.Location = new Point(292, 403);
            btnFlip.Name = "btnFlip";
            btnFlip.Size = new Size(164, 58);
            btnFlip.TabIndex = 4;
            btnFlip.Text = "Flip";
            btnFlip.UseVisualStyleBackColor = true;
            btnFlip.Click += btnFlip_Click;
            // 
            // btnCorrect
            // 
            btnCorrect.BackColor = Color.LawnGreen;
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
            btnIncorrect.BackColor = Color.Red;
            btnIncorrect.Location = new Point(556, 433);
            btnIncorrect.Name = "btnIncorrect";
            btnIncorrect.Size = new Size(164, 58);
            btnIncorrect.TabIndex = 6;
            btnIncorrect.Text = "Incorrect";
            btnIncorrect.UseVisualStyleBackColor = false;
            btnIncorrect.Click += btnIncorrect_Click;
            // 
            // PracticeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 503);
            Controls.Add(btnIncorrect);
            Controls.Add(btnCorrect);
            Controls.Add(btnFlip);
            Controls.Add(cardBackControl);
            Controls.Add(cardFrontControl);
            Controls.Add(btnExit);
            Name = "PracticeForm";
            Text = "Practice";
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private CardFrontControl cardFrontControl;
        private CardBackControl cardBackControl;
        private Button btnFlip;
        private Button btnCorrect;
        private Button btnIncorrect;
    }
}