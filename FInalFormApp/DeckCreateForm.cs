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
            // Check if a deck is inputed, if not create a new deck. Use the inputed deck otherwise.
            if (deck == null)
            {
                Deck = new Deck();
            }
            else
            {
                Deck = deck;
            }
            InitializeComponent();
        }

        // Returns the deck edited or created deck in the form.
        public Deck GetDeck()
        {
            return Deck;
        }

        // Validates that the required fields are filled before closing the form and saving the deck
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
            this.Close();
        }

        private void DeckForm_Load(object sender, EventArgs e)
        {
            // bind the deck's properties to the form's textboxes
            tbDeckName.DataBindings.Add("Text", Deck, "Name");
            tbDeckType.DataBindings.Add("Text", Deck, "Category");
        }

        // Close the form when the cancel button is clicked without saving any changes to the deck
        private void lblCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
