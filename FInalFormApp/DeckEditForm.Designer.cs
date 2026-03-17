namespace FlashcardApp
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
            lblName = new Label();
            lblCardCount = new Label();
            lblType = new Label();
            btnExit = new Button();
            btnEditDeck = new Button();
            gbDeckEdit = new GroupBox();
            gbDangerEdits = new GroupBox();
            lvCards = new ListView();
            chId = new ColumnHeader();
            chQuestion = new ColumnHeader();
            chQuestionNotes = new ColumnHeader();
            chAnswer = new ColumnHeader();
            chAnswerNotes = new ColumnHeader();
            gbDeckEdit.SuspendLayout();
            gbDangerEdits.SuspendLayout();
            SuspendLayout();
            // 
            // lblNameLabel
            // 
            lblNameLabel.AutoSize = true;
            lblNameLabel.Location = new Point(15, 25);
            lblNameLabel.Name = "lblNameLabel";
            lblNameLabel.Size = new Size(49, 20);
            lblNameLabel.TabIndex = 0;
            lblNameLabel.Text = "Name";
            // 
            // lblCardCountLabel
            // 
            lblCardCountLabel.AutoSize = true;
            lblCardCountLabel.Location = new Point(15, 64);
            lblCardCountLabel.Name = "lblCardCountLabel";
            lblCardCountLabel.Size = new Size(83, 20);
            lblCardCountLabel.TabIndex = 1;
            lblCardCountLabel.Text = "Card Count";
            // 
            // lblTypeLabel
            // 
            lblTypeLabel.AutoSize = true;
            lblTypeLabel.Location = new Point(15, 105);
            lblTypeLabel.Name = "lblTypeLabel";
            lblTypeLabel.Size = new Size(40, 20);
            lblTypeLabel.TabIndex = 2;
            lblTypeLabel.Text = "Type";
            // 
            // btnNewCard
            // 
            btnNewCard.Location = new Point(19, 157);
            btnNewCard.Name = "btnNewCard";
            btnNewCard.Size = new Size(94, 29);
            btnNewCard.TabIndex = 3;
            btnNewCard.Text = "New Card";
            btnNewCard.UseVisualStyleBackColor = true;
            btnNewCard.Click += btnNewCard_Click;
            // 
            // btnEditCard
            // 
            btnEditCard.Location = new Point(19, 192);
            btnEditCard.Name = "btnEditCard";
            btnEditCard.Size = new Size(94, 29);
            btnEditCard.TabIndex = 4;
            btnEditCard.Text = "Edit Card";
            btnEditCard.UseVisualStyleBackColor = true;
            btnEditCard.Click += btnEditCard_Click;
            // 
            // btnRemoveDeck
            // 
            btnRemoveDeck.Location = new Point(15, 26);
            btnRemoveDeck.Name = "btnRemoveDeck";
            btnRemoveDeck.Size = new Size(98, 29);
            btnRemoveDeck.TabIndex = 5;
            btnRemoveDeck.Text = "Delete Deck";
            btnRemoveDeck.UseVisualStyleBackColor = true;
            btnRemoveDeck.Click += btnRemoveDeck_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(70, 25);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 7;
            lblName.Text = "Name";
            // 
            // lblCardCount
            // 
            lblCardCount.AutoSize = true;
            lblCardCount.Location = new Point(104, 64);
            lblCardCount.Name = "lblCardCount";
            lblCardCount.Size = new Size(17, 20);
            lblCardCount.TabIndex = 8;
            lblCardCount.Text = "0";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(61, 105);
            lblType.Name = "lblType";
            lblType.Size = new Size(40, 20);
            lblType.TabIndex = 9;
            lblType.Text = "Type";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(19, 262);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnEditDeck
            // 
            btnEditDeck.Location = new Point(19, 227);
            btnEditDeck.Name = "btnEditDeck";
            btnEditDeck.Size = new Size(94, 29);
            btnEditDeck.TabIndex = 11;
            btnEditDeck.Text = "Edit Deck";
            btnEditDeck.UseVisualStyleBackColor = true;
            btnEditDeck.Click += btnEditDeck_Click;
            // 
            // gbDeckEdit
            // 
            gbDeckEdit.AutoSize = true;
            gbDeckEdit.Controls.Add(btnEditCard);
            gbDeckEdit.Controls.Add(lblNameLabel);
            gbDeckEdit.Controls.Add(btnEditDeck);
            gbDeckEdit.Controls.Add(lblCardCountLabel);
            gbDeckEdit.Controls.Add(btnExit);
            gbDeckEdit.Controls.Add(lblTypeLabel);
            gbDeckEdit.Controls.Add(lblType);
            gbDeckEdit.Controls.Add(btnNewCard);
            gbDeckEdit.Controls.Add(lblCardCount);
            gbDeckEdit.Controls.Add(lblName);
            gbDeckEdit.Location = new Point(12, 12);
            gbDeckEdit.Name = "gbDeckEdit";
            gbDeckEdit.Size = new Size(130, 317);
            gbDeckEdit.TabIndex = 13;
            gbDeckEdit.TabStop = false;
            gbDeckEdit.Text = "Deck Edit";
            // 
            // gbDangerEdits
            // 
            gbDangerEdits.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            gbDangerEdits.AutoSize = true;
            gbDangerEdits.Controls.Add(btnRemoveDeck);
            gbDangerEdits.Location = new Point(12, 374);
            gbDangerEdits.Name = "gbDangerEdits";
            gbDangerEdits.Size = new Size(130, 64);
            gbDangerEdits.TabIndex = 14;
            gbDangerEdits.TabStop = false;
            gbDangerEdits.Text = "Danger";
            // 
            // lvCards
            // 
            lvCards.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lvCards.Columns.AddRange(new ColumnHeader[] { chId, chQuestion, chQuestionNotes, chAnswer, chAnswerNotes });
            lvCards.FullRowSelect = true;
            lvCards.Location = new Point(148, 12);
            lvCards.Name = "lvCards";
            lvCards.Size = new Size(640, 426);
            lvCards.TabIndex = 15;
            lvCards.UseCompatibleStateImageBehavior = false;
            lvCards.View = View.Details;
            lvCards.SelectedIndexChanged += lvCards_SelectedIndexChanged;
            // 
            // chId
            // 
            chId.Text = "Id";
            // 
            // chQuestion
            // 
            chQuestion.Text = "Question";
            chQuestion.Width = 120;
            // 
            // chQuestionNotes
            // 
            chQuestionNotes.Text = "Question Notes";
            chQuestionNotes.Width = 160;
            // 
            // chAnswer
            // 
            chAnswer.Text = "Answer";
            chAnswer.Width = 120;
            // 
            // chAnswerNotes
            // 
            chAnswerNotes.Text = "Answer Notes";
            chAnswerNotes.Width = 160;
            // 
            // DeckEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvCards);
            Controls.Add(gbDangerEdits);
            Controls.Add(gbDeckEdit);
            MinimumSize = new Size(818, 497);
            Name = "DeckEditForm";
            Text = "DeckView";
            Load += DeckEditForm_Load;
            gbDeckEdit.ResumeLayout(false);
            gbDeckEdit.PerformLayout();
            gbDangerEdits.ResumeLayout(false);
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
        private Label lblName;
        private Label lblCardCount;
        private Label lblType;
        private Button btnExit;
        private Button btnEditDeck;
        private GroupBox gbDeckEdit;
        private GroupBox gbDangerEdits;
        private ListView lvCards;
        private ColumnHeader chId;
        private ColumnHeader chQuestion;
        private ColumnHeader chQuestionNotes;
        private ColumnHeader chAnswer;
        private ColumnHeader chAnswerNotes;
    }
}