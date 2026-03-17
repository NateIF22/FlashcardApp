using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashcardApp
{
    public partial class CardBackControl : UserControl
    {
        public CardBackControl()
        {
            InitializeComponent();
        }

        // Populates the card back control with the details from the given card
        public void PopulateCardDetails(Card card)
        {
            lblAnswer.Text = card.Answer;
            tbContext.Text = card.AnswerNote;
        }
    }
}
