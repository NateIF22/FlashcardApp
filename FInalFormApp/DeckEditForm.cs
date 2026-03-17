using FlashcardApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashcardApp
{
    public partial class DeckEditForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private Deck CurrentDeck { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private Card? SelectedCard { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private BindingList<Deck> Decks { get; set; }
        public DeckEditForm(Deck currentDeck, BindingList<Deck> decks)
        {
            CurrentDeck = currentDeck;
            Decks = decks;
            InitializeComponent();
            
        }

        private void DeckEditForm_Load(object sender, EventArgs e)
        {
            lblCardCount.Text = CurrentDeck.CardCount.ToString();
            lblName.Text = CurrentDeck.Name;
            lblType.Text = CurrentDeck.Category;
            btnEditCard.Enabled = false;
            UpdateCards();
        }

        private void btnNewCard_Click(object sender, EventArgs e)
        {
            // Adds a new card to the deck and opens the card edit form to edit the empty card
            Card newCard = new Card();
            CardEditForm cardEditForm = new CardEditForm(newCard, CurrentDeck);
            cardEditForm.ShowDialog();

            //if the card was saved, add it to the deck and update the card count
            if (cardEditForm.DialogResult == DialogResult.OK)
            {
                btnEditCard.Enabled = false;
                CurrentDeck.Cards.Add(newCard);
                newCard.Id = CurrentDeck.Cards.IndexOf(newCard); // set the Id of the card to the index of the card in the list of cards
                CurrentDeck.CardCount = CurrentDeck.Cards.Count;
                lblCardCount.Text = CurrentDeck.CardCount.ToString();
                
                UpdateCards();
            }
        }

        private void lvCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if no card is selected, disable the edit card button and return
            if (lvCards.SelectedIndices.Count == 0)
            {
                btnEditCard.Enabled = false;
                return;
            }

            // enable the edit card button when a card is selected in the list view
            Card selectedCard = CurrentDeck.Cards[lvCards.SelectedIndices[0]];
            SelectedCard = selectedCard;
            btnEditCard.Enabled = true;

        }

        private void UpdateCards()
        {
            lvCards.Items.Clear();
            // Logic to update the list view with the cards in the deck.
            foreach (Card card in CurrentDeck.Cards)
            {
                // goes therough the columns and adds the card details to each column for each card in the deck
                ListViewItem newItem = new ListViewItem(card.Id.ToString());
                newItem.SubItems.Add(card.Question);
                newItem.SubItems.Add(card.QuestionNote);
                newItem.SubItems.Add(card.Answer);
                newItem.SubItems.Add(card.AnswerNote);
                lvCards.Items.Add(newItem);
            }
        }

        // Opens the card edit form for the selected card when the edit card button is pressed
        private void btnEditCard_Click(object sender, EventArgs e)
        {
            if (SelectedCard != null)
            {
                CardEditForm cardEditForm = new CardEditForm(SelectedCard, CurrentDeck);
                cardEditForm.ShowDialog();
                if (cardEditForm.DialogResult == DialogResult.OK)
                {
                    UpdateCards();
                }
            }
        }

        // Removes the current deck from the list of decks after confirmation
        private void btnRemoveDeck_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                $"Are you sure you want to delete the deck: {CurrentDeck.Name}? This is permanent",
                "Confirm Delete?",
                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
                MessageBox.Show($"Deck: {CurrentDeck.Name} removed successfully.", "Deck Removal");
                Decks.Remove(CurrentDeck);
            }
        }

        // Closes the form without saving changes
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Opens the deck edit form for the currently selected deck when the edit deck button is pressed
        private void btnEditDeck_Click(object sender, EventArgs e)
        {
            DeckCreateForm deckCreateForm = new DeckCreateForm(CurrentDeck);
            if (deckCreateForm.ShowDialog() == DialogResult.OK)
            {
                lblName.Text = CurrentDeck.Name;
                lblType.Text = CurrentDeck.Category;
            }
        }
    }
}
