using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalFormApp
{
    public partial class CardBackControl : UserControl
    {
        public CardBackControl()
        {
            InitializeComponent();
        }

        // Populate the card details on the back of the card with card data
        public void PopulateCardDetails(Card card)
        {
            lblAnswer.Text = card.Answer;
            tbContext.Text = card.AnswerNote;
        }
    }
}
