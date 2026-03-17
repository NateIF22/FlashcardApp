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
        // TODO: Add properties for the card answer and any additional details that should be displayed on the back of the card
        public CardBackControl()
        {
            InitializeComponent();
        }

        public void PopulateCardDetails(Card card)
        {
            lblAnswer.Text = card.Answer;
            tbContext.Text = card.AnswerNote;
        }
    }
}
