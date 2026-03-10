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
            btnNewCard = new Button();
            btnEditCard = new Button();
            flpDecks = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnNewCard
            // 
            btnNewCard.Location = new Point(636, 12);
            btnNewCard.Name = "btnNewCard";
            btnNewCard.Size = new Size(94, 29);
            btnNewCard.TabIndex = 1;
            btnNewCard.Text = "New Card";
            btnNewCard.UseVisualStyleBackColor = true;
            // 
            // btnEditCard
            // 
            btnEditCard.Location = new Point(12, 12);
            btnEditCard.Name = "btnEditCard";
            btnEditCard.Size = new Size(94, 29);
            btnEditCard.TabIndex = 2;
            btnEditCard.Text = "Edit Card";
            btnEditCard.UseVisualStyleBackColor = true;
            // 
            // flpDecks
            // 
            flpDecks.Location = new Point(12, 56);
            flpDecks.Name = "flpDecks";
            flpDecks.Size = new Size(718, 382);
            flpDecks.TabIndex = 3;
            flpDecks.Tag = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 450);
            Controls.Add(flpDecks);
            Controls.Add(btnEditCard);
            Controls.Add(btnNewCard);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnNewCard;
        private Button btnEditCard;
        private FlowLayoutPanel flpDecks;
    }
}
