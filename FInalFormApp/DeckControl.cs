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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private BindingList<Deck> Decks { get; set; }

        public DeckControl(Deck deckDetails, BindingList<Deck> decks)
        {
            InitializeComponent();
            Decks = decks;
            DeckDetails = deckDetails;

            // Syncs the labels with the deck details
            lblName.DataBindings.Add("Text", DeckDetails, "Name");
            lblCategory.DataBindings.Add("Text", DeckDetails, "Category");
        }



        private void btnPractice_Click(object sender, EventArgs e)
        {
            if (DeckDetails.CardCount == 0)
            {
                MessageBox.Show("Please add cards before practicing.", "No Cards", MessageBoxButtons.OK);
                return;
            }
            PracticeForm practiceForm = new PracticeForm(DeckDetails);
            practiceForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var deckEditForm = new DeckEditForm(DeckDetails, Decks);
            deckEditForm.ShowDialog();
        }
    }
}
