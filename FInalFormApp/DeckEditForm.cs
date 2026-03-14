using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalFormApp
{
    public partial class DeckEditForm : Form
    {
        public Deck DeckDetails { get; set; }
        public DeckEditForm(Deck deckDetails)
        {
            InitializeComponent();
            DeckDetails = deckDetails;
        }

        private void btnNewCard_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCard_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveDeck_Click(object sender, EventArgs e)
        {

        }
    }
}
