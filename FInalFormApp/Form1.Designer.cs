namespace FInalFormApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNewDeck = new Button();
            lvDecks = new ListView();
            SuspendLayout();
            // 
            // btnNewDeck
            // 
            btnNewDeck.Location = new Point(315, 12);
            btnNewDeck.Name = "btnNewDeck";
            btnNewDeck.Size = new Size(150, 38);
            btnNewDeck.TabIndex = 1;
            btnNewDeck.Text = "New Deck";
            btnNewDeck.UseVisualStyleBackColor = true;
            btnNewDeck.Click += btnNewDeck_Click;
            // 
            // lvDecks
            // 
            lvDecks.Location = new Point(12, 56);
            lvDecks.Name = "lvDecks";
            lvDecks.Size = new Size(758, 385);
            lvDecks.TabIndex = 2;
            lvDecks.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(lvDecks);
            Controls.Add(btnNewDeck);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnNewDeck;
        private ListView lvDecks;
    }
}
