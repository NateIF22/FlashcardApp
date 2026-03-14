namespace FinalFormApp
{
    partial class DeckControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblCategoryLabel = new Label();
            btnPractice = new Button();
            lblCategory = new Label();
            btnEdit = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(51, 14);
            lblName.Name = "lblName";
            lblName.Size = new Size(98, 31);
            lblName.TabIndex = 0;
            lblName.Text = "Spanish";
            // 
            // lblCategoryLabel
            // 
            lblCategoryLabel.AutoSize = true;
            lblCategoryLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCategoryLabel.Location = new Point(19, 56);
            lblCategoryLabel.Name = "lblCategoryLabel";
            lblCategoryLabel.Size = new Size(88, 25);
            lblCategoryLabel.TabIndex = 1;
            lblCategoryLabel.Text = "Category:";
            // 
            // btnPractice
            // 
            btnPractice.BackColor = Color.Transparent;
            btnPractice.Location = new Point(4, 93);
            btnPractice.Name = "btnPractice";
            btnPractice.Size = new Size(94, 29);
            btnPractice.TabIndex = 3;
            btnPractice.Text = "Practice";
            btnPractice.UseVisualStyleBackColor = false;
            btnPractice.Click += btnPractice_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(113, 60);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(74, 20);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Language";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(104, 93);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(102, 29);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // DeckControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(btnEdit);
            Controls.Add(lblCategory);
            Controls.Add(btnPractice);
            Controls.Add(lblCategoryLabel);
            Controls.Add(lblName);
            Name = "DeckControl";
            Size = new Size(209, 126);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblCategoryLabel;
        private Label lblCardNumberLabel;
        private Button btnPractice;
        private Label lblCategory;
        private Label lblCardNumber;
        private Button btnEdit;
    }
}
