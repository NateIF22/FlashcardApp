namespace FinalFormApp
{
    partial class DeckForm
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
            tbDeckCategory = new TextBox();
            lblDeckCategory = new Label();
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
            lblDeckName.Location = new Point(22, 20);
            lblDeckName.Name = "lblDeckName";
            lblDeckName.Size = new Size(49, 20);
            lblDeckName.TabIndex = 2;
            lblDeckName.Text = "Name";
            // 
            // tbDeckName
            // 
            tbDeckName.Location = new Point(78, 17);
            tbDeckName.Name = "tbDeckName";
            tbDeckName.Size = new Size(239, 27);
            tbDeckName.TabIndex = 3;
            // 
            // tbDeckCategory
            // 
            tbDeckCategory.Location = new Point(78, 50);
            tbDeckCategory.Name = "tbDeckCategory";
            tbDeckCategory.Size = new Size(239, 27);
            tbDeckCategory.TabIndex = 7;
            // 
            // lblDeckCategory
            // 
            lblDeckCategory.AutoSize = true;
            lblDeckCategory.Location = new Point(22, 53);
            lblDeckCategory.Name = "lblDeckCategory";
            lblDeckCategory.Size = new Size(40, 20);
            lblDeckCategory.TabIndex = 6;
            lblDeckCategory.Text = "Type";
            // 
            // DeckForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 142);
            Controls.Add(tbDeckCategory);
            Controls.Add(lblDeckCategory);
            Controls.Add(tbDeckName);
            Controls.Add(lblDeckName);
            Controls.Add(lblCancel);
            Controls.Add(lblSave);
            Name = "DeckForm";
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
        private TextBox tbDeckCategory;
        private Label lblDeckCategory;
    }
}