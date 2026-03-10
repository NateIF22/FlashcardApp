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
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            lblType = new Label();
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
            // textBox1
            // 
            textBox1.Location = new Point(78, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(78, 50);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(239, 27);
            textBox3.TabIndex = 7;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(22, 53);
            lblType.Name = "lblType";
            lblType.Size = new Size(40, 20);
            lblType.TabIndex = 6;
            lblType.Text = "Type";
            // 
            // DeckForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 142);
            Controls.Add(textBox3);
            Controls.Add(lblType);
            Controls.Add(textBox1);
            Controls.Add(lblDeckName);
            Controls.Add(lblCancel);
            Controls.Add(lblSave);
            Name = "DeckForm";
            Text = "DeckForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button lblSave;
        private Button lblCancel;
        private Label lblDeckName;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label lblType;
    }
}