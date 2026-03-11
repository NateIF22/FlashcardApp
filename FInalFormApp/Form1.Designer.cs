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
            btnEditDeck = new Button();
            fpDecks = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnNewDeck
            // 
            btnNewDeck.Location = new Point(636, 12);
            btnNewDeck.Name = "btnNewDeck";
            btnNewDeck.Size = new Size(94, 29);
            btnNewDeck.TabIndex = 1;
            btnNewDeck.Text = "New Deck";
            btnNewDeck.UseVisualStyleBackColor = true;
            btnNewDeck.Click += btnNewDeck_Click;
            // 
            // btnEditDeck
            // 
            btnEditDeck.Location = new Point(12, 12);
            btnEditDeck.Name = "btnEditDeck";
            btnEditDeck.Size = new Size(94, 29);
            btnEditDeck.TabIndex = 2;
            btnEditDeck.Text = "Edit Deck";
            btnEditDeck.UseVisualStyleBackColor = true;
            btnEditDeck.Click += btnEditDeck_Click;
            // 
            // fpDecks
            // 
            fpDecks.Location = new Point(12, 56);
            fpDecks.Name = "fpDecks";
            fpDecks.Size = new Size(718, 382);
            fpDecks.TabIndex = 3;
            fpDecks.Tag = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 450);
            Controls.Add(fpDecks);
            Controls.Add(btnEditDeck);
            Controls.Add(btnNewDeck);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnNewDeck;
        private Button btnEditDeck;
        private FlowLayoutPanel fpDecks;
    }
}
