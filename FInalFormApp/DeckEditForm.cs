using FInalFormApp;
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
        private Deck DeckDetails { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private Card? SelectedCard { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private BindingList<Deck> Decks { get; set; }
        public DeckEditForm(Deck deckDetails, BindingList<Deck> decks)
        {
            DeckDetails = deckDetails;
            Decks = decks;
            InitializeComponent();
            
        }

        private void DeckEditForm_Load(object sender, EventArgs e)
        {
            lblCardCount.Text = DeckDetails.CardCount.ToString();
            lblName.Text = DeckDetails.Name;
            lblType.Text = DeckDetails.Category;
            btnEditCard.Enabled = false;
            UpdateCards();
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
                btnEditCard.Enabled = false;
                DeckDetails.Cards.Add(newCard);
                newCard.Id = DeckDetails.Cards.IndexOf(newCard); // set the ID of the card to the index of the card in the list of cards
                DeckDetails.CardCount = DeckDetails.Cards.Count;
                lblCardCount.Text = DeckDetails.CardCount.ToString();
                
                UpdateCards();
            }
        }

        private void lvCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCards.SelectedIndices.Count == 0)
            {
                btnEditCard.Enabled = false;
                return;
            }
            // logic to enable the edit card button when a card is selected in the list vie
            Card selectedCard = DeckDetails.Cards[lvCards.SelectedIndices[0]];
            SelectedCard = selectedCard;
            btnEditCard.Enabled = true;

        }

        private void UpdateCards()
        {
            lvCards.Items.Clear();
            // Logic to update the list view with the cards in the deck.
            foreach (Card card in DeckDetails.Cards)
            {
                // goes therough the columns
                ListViewItem newItem = new ListViewItem(card.Id.ToString());
                newItem.SubItems.Add(card.Question);
                newItem.SubItems.Add(card.QuestionNote);
                newItem.SubItems.Add(card.Answer);
                newItem.SubItems.Add(card.AnswerNote);
                lvCards.Items.Add(newItem);
            }
        }

        private void btnEditCard_Click(object sender, EventArgs e)
        {
            if (SelectedCard != null)
            {
                CardEditForm cardEditForm = new CardEditForm(SelectedCard, DeckDetails);
                cardEditForm.ShowDialog();
                if (cardEditForm.DialogResult == DialogResult.OK)
                {
                    UpdateCards();
                }
            }
        }

        private void btnRemoveDeck_Click(object sender, EventArgs e)
        {
            // remove the deck from the list of decks in the main form. Closes the edit form after removing the deck
            var confirmResult = MessageBox.Show(
                $"Are you sure you want to delete the deck: {DeckDetails.Name}? This is permanent",
                "Confirm Delete?",
                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
                MessageBox.Show($"Deck: {DeckDetails.Name} removed successfully.", "Deck Removal");
                Decks.Remove(DeckDetails);
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
            if (deckCreateForm.ShowDialog() == DialogResult.OK)
            {
                // Update the deck details and refresh the labels on the form
                lblName.Text = DeckDetails.Name;
                lblType.Text = DeckDetails.Category;
            }
        }
    }
}
