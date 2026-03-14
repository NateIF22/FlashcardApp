namespace FinalFormApp
{
    partial class DeckView
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
            lblNameLabel = new Label();
            lblCardCountLabel = new Label();
            lblTypeLabel = new Label();
            btnNewCard = new Button();
            btnEditCard = new Button();
            btnRemoveDeck = new Button();
            lvCards = new ListView();
            SuspendLayout();
            // 
            // lblNameLabel
            // 
            lblNameLabel.AutoSize = true;
            lblNameLabel.Location = new Point(20, 16);
            lblNameLabel.Name = "lblNameLabel";
            lblNameLabel.Size = new Size(49, 20);
            lblNameLabel.TabIndex = 0;
            lblNameLabel.Text = "Name";
            // 
            // lblCardCountLabel
            // 
            lblCardCountLabel.AutoSize = true;
            lblCardCountLabel.Location = new Point(20, 55);
            lblCardCountLabel.Name = "lblCardCountLabel";
            lblCardCountLabel.Size = new Size(83, 20);
            lblCardCountLabel.TabIndex = 1;
            lblCardCountLabel.Text = "Card Count";
            // 
            // lblTypeLabel
            // 
            lblTypeLabel.AutoSize = true;
            lblTypeLabel.Location = new Point(20, 96);
            lblTypeLabel.Name = "lblTypeLabel";
            lblTypeLabel.Size = new Size(40, 20);
            lblTypeLabel.TabIndex = 2;
            lblTypeLabel.Text = "Type";
            // 
            // btnNewCard
            // 
            btnNewCard.Location = new Point(20, 136);
            btnNewCard.Name = "btnNewCard";
            btnNewCard.Size = new Size(94, 29);
            btnNewCard.TabIndex = 3;
            btnNewCard.Text = "New Card";
            btnNewCard.UseVisualStyleBackColor = true;
            btnNewCard.Click += btnNewCard_Click;
            // 
            // btnEditCard
            // 
            btnEditCard.Location = new Point(20, 171);
            btnEditCard.Name = "btnEditCard";
            btnEditCard.Size = new Size(94, 29);
            btnEditCard.TabIndex = 4;
            btnEditCard.Text = "Edit Card";
            btnEditCard.UseVisualStyleBackColor = true;
            btnEditCard.Click += btnEditCard_Click;
            // 
            // btnRemoveDeck
            // 
            btnRemoveDeck.Location = new Point(12, 409);
            btnRemoveDeck.Name = "btnRemoveDeck";
            btnRemoveDeck.Size = new Size(106, 29);
            btnRemoveDeck.TabIndex = 5;
            btnRemoveDeck.Text = "Delete Deck";
            btnRemoveDeck.UseVisualStyleBackColor = true;
            btnRemoveDeck.Click += btnRemoveDeck_Click;
            // 
            // lvCards
            // 
            lvCards.Location = new Point(155, 12);
            lvCards.Name = "lvCards";
            lvCards.Size = new Size(633, 426);
            lvCards.TabIndex = 6;
            lvCards.UseCompatibleStateImageBehavior = false;
            // 
            // DeckView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvCards);
            Controls.Add(btnRemoveDeck);
            Controls.Add(btnEditCard);
            Controls.Add(btnNewCard);
            Controls.Add(lblTypeLabel);
            Controls.Add(lblCardCountLabel);
            Controls.Add(lblNameLabel);
            Name = "DeckView";
            Text = "DeckView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNameLabel;
        private Label lblCardCountLabel;
        private Label lblTypeLabel;
        private Button btnNewCard;
        private Button btnEditCard;
        private Button btnRemoveDeck;
        private ListView lvCards;
    }
}