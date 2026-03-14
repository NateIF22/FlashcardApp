using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalFormApp
{
    public partial class DeckEditForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

        public Deck DeckDetails { get; set; }
        public DeckEditForm(Deck deckDetails)
        {
            InitializeComponent();
            DeckDetails = deckDetails;
        }

        private void btnNewCard_Click(object sender, EventArgs e)
        {
            // Adds a new card to the deck and updates the card count. Opens the card form for the new card and waits for it to close before reenabling the button(
            Card newCard = new Card();
            CardEditForm cardEditForm = new CardEditForm(newCard, DeckDetails);
            cardEditForm.ShowDialog();

            //if the card was saved, add it to the deck and update the card count
            if (cardEditForm.DialogResult == DialogResult.OK)
            {
                DeckDetails.Cards.Add(newCard);
                DeckDetails.CardCount = DeckDetails.Cards.Count;
                lblCardCount.Text = DeckDetails.CardCount.ToString();
            }
        }

        private void btnEditCard_Click(object sender, EventArgs e)
        {
            // Logic to edit the selected card in the list view. Opens the card form for the selected card and waits for it to close before reenabling the button
        }

        private void btnRemoveDeck_Click(object sender, EventArgs e)
        {
            // Logic to remove the deck from the list of decks in the main form. Closes the edit form after removing the deck
        }

        private void UpdateCardList()
        {
            lvCards.Items.Clear();
            foreach (Card card in DeckDetails.Cards)
            {
                // Adds each card in the deck to the list view
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Returns to the main menu and refreshes the list of decks in the main form
            this.Close();
        }

        private void btnEditDeck_Click(object sender, EventArgs e)
        {
            // Logic to edit the deck details (name and category). Updates the labels on the form after editing the details
            DeckCreateForm deckCreateForm = new DeckCreateForm(DeckDetails);
        }
    }
}
