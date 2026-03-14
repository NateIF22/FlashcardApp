namespace FinalFormApp
{
    partial class DeckCreateForm
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
            lblSave = new Button();
            lblCancel = new Button();
            lblDeckName = new Label();
            tbDeckName = new TextBox();
            tbDeckType = new TextBox();
            lblDeckType = new Label();
            SuspendLayout();
            // 
            // lblSave
            // 
            lblSave.Location = new Point(223, 94);
            lblSave.Name = "lblSave";
            lblSave.Size = new Size(94, 29);
            lblSave.TabIndex = 0;
            lblSave.Text = "Save";
            lblSave.UseVisualStyleBackColor = true;
            lblSave.Click += lblSave_Click;
            // 
            // lblCancel
            // 
            lblCancel.Location = new Point(22, 94);
            lblCancel.Name = "lblCancel";
            lblCancel.Size = new Size(94, 29);
            lblCancel.TabIndex = 1;
            lblCancel.Text = "Cancel";
            lblCancel.UseVisualStyleBackColor = true;
            lblCancel.Click += lblCancel_Click;
            // 
            // lblDeckName
            // 
            lblDeckName.AutoSize = true;
            lblDeckName.Location = new Point(28, 20);
            lblDeckName.Name = "lblDeckName";
            lblDeckName.Size = new Size(56, 20);
            lblDeckName.TabIndex = 2;
            lblDeckName.Text = "Name: ";
            // 
            // tbDeckName
            // 
            tbDeckName.Location = new Point(90, 17);
            tbDeckName.Name = "tbDeckName";
            tbDeckName.PlaceholderText = "German";
            tbDeckName.Size = new Size(227, 27);
            tbDeckName.TabIndex = 3;
            // 
            // tbDeckType
            // 
            tbDeckType.Location = new Point(90, 50);
            tbDeckType.Name = "tbDeckType";
            tbDeckType.PlaceholderText = "Language";
            tbDeckType.Size = new Size(227, 27);
            tbDeckType.TabIndex = 7;
            // 
            // lblDeckType
            // 
            lblDeckType.AutoSize = true;
            lblDeckType.Location = new Point(37, 53);
            lblDeckType.Name = "lblDeckType";
            lblDeckType.Size = new Size(47, 20);
            lblDeckType.TabIndex = 6;
            lblDeckType.Text = "Type: ";
            // 
            // DeckCreateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 142);
            Controls.Add(tbDeckType);
            Controls.Add(lblDeckType);
            Controls.Add(tbDeckName);
            Controls.Add(lblDeckName);
            Controls.Add(lblCancel);
            Controls.Add(lblSave);
            Name = "DeckCreateForm";
            Text = "DeckForm";
            Load += DeckForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button lblSave;
        private Button lblCancel;
        private Label lblDeckName;
        private TextBox tbDeckName;
        private TextBox tbDeckType;
        private Label lblDeckType;
    }
}