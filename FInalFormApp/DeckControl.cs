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
            lblCardNumber.DataBindings.Add("Text", DeckDetails, "CardCount");
        }

        private void btnPractice_Click(object sender, EventArgs e)
        {
            // opens the practice form for the deck
            PracticeForm practiceForm = new PracticeForm(DeckDetails);
            practiceForm.Show();
            btnPractice.Enabled = false;
            btnPractice.Text = "Practicing...";
        }

        private void DeckControl_MouseHover(object sender, EventArgs e)
        {
            // Changes the background color of the control when hovered over

        }
    }
}
