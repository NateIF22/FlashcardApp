using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashcardApp
{
    public partial class DeckControl : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Deck DeckDetails { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private BindingList<Deck> Decks { get; set; }

        public DeckControl(Deck deckDetails, BindingList<Deck> decks)
        {
            InitializeComponent();
            Decks = decks;
            DeckDetails = deckDetails;

            // Syncs the labels with the deck details
            lblName.DataBindings.Add("Text", DeckDetails, "Name");
            lblCategory.DataBindings.Add("Text", DeckDetails, "Category");
        }

        // Opens the practice form for the current deck when the button is pressed
        private void btnPractice_Click(object sender, EventArgs e)
        {
            // Validate that there are cards in the deck before continuing
            if (DeckDetails.CardCount == 0)
            {
                MessageBox.Show("Please add cards before practicing.", "No Cards", MessageBoxButtons.OK);
                return;
            }
            // Open the practice form for the current deck
            PracticeForm practiceForm = new PracticeForm(DeckDetails);
            practiceForm.ShowDialog();
        }

        // Opens the current deck in the deck edit form when the button is pressed
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var deckEditForm = new DeckEditForm(DeckDetails, Decks);
            deckEditForm.ShowDialog();
        }
    }
}
