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
    public partial class PracticeForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        // The list of cards that are being practiced
        public List<Card> CardsInPractice { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CurrentCardIndex { get; set; } = 0;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Card CurrentCard { get; set; }
        public PracticeForm(Deck DeckToPractice)
        {
            InitializeComponent();

            // Set the initial visibility of the controls and populate the card list
            cardBackControl.Visible = false;
            ButtonVisibility(false);
            btnFlip.BringToFront();
            CardsInPractice = new List<Card>(DeckToPractice.Cards);

            // If there are cards in the deck, populate the first card's details within the cardFrontControl.
            if (CardsInPractice.Count > 0 ) 
            {
                CurrentCard = CardsInPractice[0];
                if (CurrentCard != null)
                {
                    cardFrontControl.PopulateCardDetails(CurrentCard);
                }
            }

            else
            {
                MessageBox.Show("Error, there are no cards in this deck.", "No Cards", MessageBoxButtons.OK);
                this.Close();
            }
        }

        // Closes the practice form when the exit button is pressed
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Switches the vilibility of the card front and back controls
        // Shows the correct and incorrect buttons when the back of the card is shown
        private void btnFlip_Click(object sender, EventArgs e)
        { 
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

        // Sets the visibility of the correct and incorrect buttons based on the inputed bool
        private void ButtonVisibility(bool isVisible)
        {
            btnCorrect.Visible = isVisible;
            btnIncorrect.Visible = isVisible;
        }

        //Switches vilibility and updated the details of the cards
        private void SwitchCardVisibility()
        {
            // Switches the vilibility of the front and back of the cards
            cardBackControl.Visible = !cardBackControl.Visible;
            cardFrontControl.Visible = !cardFrontControl.Visible;

            // Switch the vilibility of the card side controls
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

        // Logic for when the 'correct' button is pressed 
        private void btnCorrect_Click(object sender, EventArgs e)
        {
            CurrentCardIndex++;
            if (CurrentCardIndex < CardsInPractice.Count)
            {
                // Logic to get the next card
                CurrentCard = CardsInPractice[CurrentCardIndex];

                // Switch the visibility of the card front and back controls
                SwitchCardVisibility();

                // populate the details of the new card
                cardFrontControl.PopulateCardDetails(CurrentCard);
            }
            // If there are no more cards, show a message box and close the practice form
            else
            {
                MessageBox.Show("You have completed all the cards in this deck", "Deck Completed");
                this.Close();
            }
        }

        // Logic for when the 'incorrect' button is pressed
        private void btnIncorrect_Click(object sender, EventArgs e)
        {
            // Send the current card to the back of the list of cards in practice and show the next card
            CardsInPractice.RemoveAt(CurrentCardIndex);
            CardsInPractice.Add(CurrentCard);
            CurrentCard = CardsInPractice[CurrentCardIndex];

            // Switch the visibility of the card front and back controls
            SwitchCardVisibility();

            // populate the details of the new card
            cardFrontControl.PopulateCardDetails(CurrentCard);
        }
    }
}
