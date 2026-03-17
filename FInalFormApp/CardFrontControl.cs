using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashcardApp
{
    public partial class CardFrontControl : UserControl
    {
        public CardFrontControl()
        {
            InitializeComponent();
        }

        // Populate the card details on the front of the card with card data
        public void PopulateCardDetails(Card card)
        {
            lblQuestion.Text = card.Question;
            tbContext.Text = card.QuestionNote;
        }
    }
}
