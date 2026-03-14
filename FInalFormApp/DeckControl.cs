using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalFormApp
{
    public partial class DeckControl : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Deck DeckDetails { get; set; }

        public DeckControl(Deck deckDetails)
        {
            InitializeComponent();
            DeckDetails = deckDetails;

            // Syncs the labels with the deck details
            lblName.DataBindings.Add("Text", DeckDetails, "Name");
            lblCategory.DataBindings.Add("Text", DeckDetails, "Category");
        }



        private void btnPractice_Click(object sender, EventArgs e)
        {
            if (DeckDetails.Cards.Count == 0)
            {
                MessageBox.Show("This deck has no cards to practice with. Please add some cards before practicing.", "No Cards");
                return;
            }
            PracticeForm practiceForm = new PracticeForm(DeckDetails);
            practiceForm.ShowDialog();
        }

        private void DeckControl_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void DeckControl_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;

        }

        private void DeckControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
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
                lblCardNumber.Text = DeckDetails.Cards.Count.ToString();
            }

        }
    }
}
