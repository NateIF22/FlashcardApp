using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalFormApp
{
    public partial class CardEditForm : Form
    {
        public Deck _deck;
        public Card card;
        public CardEditForm(Deck deck)
        {
            InitializeComponent();
            _deck = deck;
            card = new Card();
            // create a new card
            //use databinding to synch tb's with cards data
            // add the card to the deck if saved


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Card saved to {_deck.Name}");
            this.DialogResult = DialogResult.OK;
            _deck.CardCount = _deck.Cards.Count;
            this.Close();
        }

        private void CardEditForm_Load(object sender, EventArgs e)
        {
            // Bind the created card's properties to the text boxes
            tbQuestion.DataBindings.Add("Text", card, "Question");
            tbQuestionNote.DataBindings.Add("Text", card, "QuestionNote");
            tbAnswer.DataBindings.Add("Text", card, "Answer");
            tbAnswerNote.DataBindings.Add("Text", card, "AnswerNote");
        }
    }
}
