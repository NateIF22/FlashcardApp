using FinalFormApp;
using System.ComponentModel;

namespace FInalFormApp
{
    
    public partial class Form1 : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<Deck> Decks { get; set; }
        public Form1()
        {
            InitializeComponent();
            Decks = new BindingList<Deck>();
        }

        private void UpdateDeckList()
        {
            // Logic to update the list box with the current decks
            lstDecks.DataSource = null;
            lstDecks.DataSource = Decks;
            lstDecks.DisplayMember = "Name"; // Assuming Deck has a Name property
        }

        private void btnNewDeck_Click(object sender, EventArgs e)
        {
            // Logic to add a new deck to the list box
            // Add the DeckForm for creating a new deck
            DeckForm deckForm = new DeckForm();
            if (deckForm.ShowDialog() == DialogResult.OK)
            {
                // ands a new deck to the list of decks
                Decks.Add(deckForm.GetDeck());


            }
            }
    }
}
