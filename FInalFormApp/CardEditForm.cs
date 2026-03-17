using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashcardApp
{
    public partial class CardEditForm : Form
    {
        public Card _card;
        public Deck _deck;
        public CardEditForm(Card card, Deck deck)
        {
            InitializeComponent();
            _card = card;
            _deck = deck;
            // create a new card
            //use databinding to synch tb's with cards data
            // add the card to the deck if saved
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validators.IsPresent(tbQuestion.Text) == false)
            {
                MessageBox.Show("Question is required.");
                tbQuestion.Focus();
                return;
            }
            else if (Validators.IsPresent(tbAnswer.Text) == false)
            {
                MessageBox.Show("Answer is required.");
                tbAnswer.Focus();
                return;
            }
            MessageBox.Show($"Card sucessfuly saved to '{_deck.Name}'.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CardEditForm_Load(object sender, EventArgs e)
        {
            // Bind the created card's properties to the text boxes
            tbQuestion.DataBindings.Add("Text", _card, "Question");
            tbQuestionNote.DataBindings.Add("Text", _card, "QuestionNote");
            tbAnswer.DataBindings.Add("Text", _card, "Answer");
            tbAnswerNote.DataBindings.Add("Text", _card, "AnswerNote");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
