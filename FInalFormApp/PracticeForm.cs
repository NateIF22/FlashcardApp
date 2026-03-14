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
    public partial class PracticeForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        // This is the list of cards that are being practiced, when the practice form is opened, this list should be populated with the cards from the deck that is being practiced.
        public List<Card> CardsInPractice { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CurrentCardIndex { get; set; } = 0;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Card CurrentCard { get; set; }
        public PracticeForm(Deck DeckToPractice)
        {
            InitializeComponent();
            cardBackControl.Visible = false;
            ButtonVisibility(false);

            CardsInPractice = new List<Card>(DeckToPractice.Cards);

            if (CardsInPractice.Count > 0 ) 
            {
            
                // Casts the card, possibly change?
                CurrentCard = CardsInPractice[0];
                if (CurrentCard != null)
                {
                    cardFrontControl.PopulateCardDetails(CurrentCard);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            // TODO: Add logic to move to the next card in the list and update the card front and back controls with the new card details
            SwitchCardVisibility();
            if (cardBackControl.Visible) 
            {
                ButtonVisibility(true);
            }
            else
            {
                ButtonVisibility(false);
            }
        }

        private void ButtonVisibility(bool isVisible)
        {
            btnCorrect.Visible = isVisible;
            btnIncorrect.Visible = isVisible;
        }

        private void SwitchCardVisibility()
        {
            cardBackControl.Visible = !cardBackControl.Visible;
            cardFrontControl.Visible = !cardFrontControl.Visible;
            // Populate the back of the card with the current card details
            if (cardBackControl.Visible)
            {
                cardBackControl.PopulateCardDetails(CurrentCard);
                ButtonVisibility(true);
            }
            else
            {
                cardFrontControl.PopulateCardDetails(CurrentCard);
                ButtonVisibility(false);
            }
            }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            // Remove the current card from the list of cards in practice and move to the next card
            CurrentCardIndex++;
            if (CurrentCardIndex < CardsInPractice.Count)
            {
                // Logic to get the next card
                CurrentCard = CardsInPractice[CurrentCardIndex];
                SwitchCardVisibility();
                cardFrontControl.PopulateCardDetails(CurrentCard);
            }
            else
            {
                MessageBox.Show("You have completed all the cards in this deck", "Deck Completed");
                this.Close();
            }
        }

        private void btnIncorrect_Click(object sender, EventArgs e)
        {
            // Send the current card to the back of the list of cards in practice and chow the next card
            CardsInPractice.RemoveAt(CurrentCardIndex);
            CardsInPractice.Add(CurrentCard);
            CurrentCard = CardsInPractice[CurrentCardIndex];
            SwitchCardVisibility();
            cardFrontControl.PopulateCardDetails(CurrentCard);
        }
    }
}
