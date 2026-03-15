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
    public partial class DeckCreateForm : Form
    {
        private Deck Deck;
        public DeckCreateForm(Deck? deck)
        {
            if (deck == null)
            {
                Deck = new Deck();
            }
            else
            {
                Deck = deck;
            }
            InitializeComponent();
            lblDeckName.Focus();

        }

        public Deck GetDeck()
        {
            return Deck;
        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            if (Validators.IsPresent(tbDeckName.Text) == false)
            {
                MessageBox.Show("Deck name is required.");
                tbDeckName.Focus();
                return;
            }
            else if (Validators.IsPresent(tbDeckType.Text) == false)
            {
                MessageBox.Show("Deck type is required.");
                tbDeckType.Focus();
                return;
            }
            MessageBox.Show($"Deck: {Deck.Name} saved successfully!");
            this.DialogResult = DialogResult.OK;
            // Needs to show the card edit form
            this.Close();
        }

        private void DeckForm_Load(object sender, EventArgs e)
        {
            // Bind the text boxes to the deck properties
            tbDeckName.DataBindings.Add("Text", Deck, "Name");
            tbDeckType.DataBindings.Add("Text", Deck, "Category");
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
