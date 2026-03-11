using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FinalFormApp
{
    public partial class DeckForm : Form
    {
        private Deck deck;
        public DeckForm()
        {
            InitializeComponent();
            deck = new Deck();
        }

        public Deck GetDeck()
        {
            return deck;
        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Deck: {deck.Name} created successfully!");
            this.DialogResult = DialogResult.OK;
            // Needs to show the card edit form
            this.Close();
        }

        private void DeckForm_Load(object sender, EventArgs e)
        {
            // Bind the text boxes to the deck properties
            tbDeckName.DataBindings.Add("Text", deck, "Name");
            tbDeckCategory.DataBindings.Add("Text", deck, "Category");
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
