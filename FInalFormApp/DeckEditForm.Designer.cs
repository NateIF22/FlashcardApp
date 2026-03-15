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
            lblName = new Label();
            lblCardCount = new Label();
            lblType = new Label();
            btnExit = new Button();
            btnEditDeck = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            gbDeckEdit = new GroupBox();
            gbDangerEdits = new GroupBox();
            gbDeckEdit.SuspendLayout();
            gbDangerEdits.SuspendLayout();
            SuspendLayout();
            // 
            // lblNameLabel
            // 
            lblNameLabel.AutoSize = true;
            lblNameLabel.Location = new Point(11, 27);
            lblNameLabel.Name = "lblNameLabel";
            lblNameLabel.Size = new Size(49, 20);
            lblNameLabel.TabIndex = 0;
            lblNameLabel.Text = "Name";
            // 
            // lblCardCountLabel
            // 
            lblCardCountLabel.AutoSize = true;
            lblCardCountLabel.Location = new Point(11, 66);
            lblCardCountLabel.Name = "lblCardCountLabel";
            lblCardCountLabel.Size = new Size(83, 20);
            lblCardCountLabel.TabIndex = 1;
            lblCardCountLabel.Text = "Card Count";
            // 
            // lblTypeLabel
            // 
            lblTypeLabel.AutoSize = true;
            lblTypeLabel.Location = new Point(11, 107);
            lblTypeLabel.Name = "lblTypeLabel";
            lblTypeLabel.Size = new Size(40, 20);
            lblTypeLabel.TabIndex = 2;
            lblTypeLabel.Text = "Type";
            // 
            // btnNewCard
            // 
            btnNewCard.Location = new Point(15, 159);
            btnNewCard.Name = "btnNewCard";
            btnNewCard.Size = new Size(94, 29);
            btnNewCard.TabIndex = 3;
            btnNewCard.Text = "New Card";
            btnNewCard.UseVisualStyleBackColor = true;
            btnNewCard.Click += btnNewCard_Click;
            // 
            // btnEditCard
            // 
            btnEditCard.Location = new Point(15, 194);
            btnEditCard.Name = "btnEditCard";
            btnEditCard.Size = new Size(94, 29);
            btnEditCard.TabIndex = 4;
            btnEditCard.Text = "Edit Card";
            btnEditCard.UseVisualStyleBackColor = true;
            btnEditCard.Click += btnEditCard_Click;
            // 
            // btnRemoveDeck
            // 
            btnRemoveDeck.Location = new Point(11, 26);
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
            lblName.Location = new Point(66, 27);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 7;
            lblName.Text = "Name";
            // 
            // lblCardCount
            // 
            lblCardCount.AutoSize = true;
            lblCardCount.Location = new Point(100, 66);
            lblCardCount.Name = "lblCardCount";
            lblCardCount.Size = new Size(17, 20);
            lblCardCount.TabIndex = 8;
            lblCardCount.Text = "0";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(57, 107);
            lblType.Name = "lblType";
            lblType.Size = new Size(40, 20);
            lblType.TabIndex = 9;
            lblType.Text = "Type";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(15, 264);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnEditDeck
            // 
            btnEditDeck.Location = new Point(15, 229);
            btnEditDeck.Name = "btnEditDeck";
            btnEditDeck.Size = new Size(94, 29);
            btnEditDeck.TabIndex = 11;
            btnEditDeck.Text = "Edit Deck";
            btnEditDeck.UseVisualStyleBackColor = true;
            btnEditDeck.Click += btnEditDeck_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(148, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(640, 426);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // gbDeckEdit
            // 
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
            gbDeckEdit.Size = new Size(130, 301);
            gbDeckEdit.TabIndex = 13;
            gbDeckEdit.TabStop = false;
            gbDeckEdit.Text = "Deck Edit";
            // 
            // gbDangerEdits
            // 
            gbDangerEdits.Controls.Add(btnRemoveDeck);
            gbDangerEdits.Location = new Point(12, 374);
            gbDangerEdits.Name = "gbDangerEdits";
            gbDangerEdits.Size = new Size(130, 64);
            gbDangerEdits.TabIndex = 14;
            gbDangerEdits.TabStop = false;
            gbDangerEdits.Text = "Danger";
            // 
            // DeckEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbDangerEdits);
            Controls.Add(gbDeckEdit);
            Controls.Add(flowLayoutPanel1);
            Name = "DeckEditForm";
            Text = "DeckView";
            Load += DeckEditForm_Load;
            gbDeckEdit.ResumeLayout(false);
            gbDeckEdit.PerformLayout();
            gbDangerEdits.ResumeLayout(false);
            ResumeLayout(false);
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
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox gbDeckEdit;
        private GroupBox gbDangerEdits;
    }
}