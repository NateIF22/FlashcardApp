namespace FinalFormApp
{
    partial class DeckEditForm
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
            lblName = new Label();
            lblCardCount = new Label();
            lblType = new Label();
            btnExit = new Button();
            btnEditDeck = new Button();
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
            btnNewCard.Location = new Point(24, 148);
            btnNewCard.Name = "btnNewCard";
            btnNewCard.Size = new Size(94, 29);
            btnNewCard.TabIndex = 3;
            btnNewCard.Text = "New Card";
            btnNewCard.UseVisualStyleBackColor = true;
            btnNewCard.Click += btnNewCard_Click;
            // 
            // btnEditCard
            // 
            btnEditCard.Location = new Point(24, 183);
            btnEditCard.Name = "btnEditCard";
            btnEditCard.Size = new Size(94, 29);
            btnEditCard.TabIndex = 4;
            btnEditCard.Text = "Edit Card";
            btnEditCard.UseVisualStyleBackColor = true;
            btnEditCard.Click += btnEditCard_Click;
            // 
            // btnRemoveDeck
            // 
            btnRemoveDeck.Location = new Point(20, 409);
            btnRemoveDeck.Name = "btnRemoveDeck";
            btnRemoveDeck.Size = new Size(98, 29);
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
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(75, 16);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 7;
            lblName.Text = "Name";
            // 
            // lblCardCount
            // 
            lblCardCount.AutoSize = true;
            lblCardCount.Location = new Point(109, 55);
            lblCardCount.Name = "lblCardCount";
            lblCardCount.Size = new Size(17, 20);
            lblCardCount.TabIndex = 8;
            lblCardCount.Text = "0";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(66, 96);
            lblType.Name = "lblType";
            lblType.Size = new Size(40, 20);
            lblType.TabIndex = 9;
            lblType.Text = "Type";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(24, 253);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnEditDeck
            // 
            btnEditDeck.Location = new Point(24, 218);
            btnEditDeck.Name = "btnEditDeck";
            btnEditDeck.Size = new Size(94, 29);
            btnEditDeck.TabIndex = 11;
            btnEditDeck.Text = "Edit Deck";
            btnEditDeck.UseVisualStyleBackColor = true;
            btnEditDeck.Click += this.btnEditDeck_Click;
            // 
            // DeckEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditDeck);
            Controls.Add(btnExit);
            Controls.Add(lblType);
            Controls.Add(lblCardCount);
            Controls.Add(lblName);
            Controls.Add(lvCards);
            Controls.Add(btnRemoveDeck);
            Controls.Add(btnEditCard);
            Controls.Add(btnNewCard);
            Controls.Add(lblTypeLabel);
            Controls.Add(lblCardCountLabel);
            Controls.Add(lblNameLabel);
            Name = "DeckEditForm";
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
        private Label lblName;
        private Label lblCardCount;
        private Label lblType;
        private Button btnExit;
        private Button btnEditDeck;
    }
}