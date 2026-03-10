using FinalFormApp;

namespace FInalFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewDeck_Click(object sender, EventArgs e)
        {
            // Logic to add a new deck to the list box
            // Add the DeckForm for creating a new deck
            DeckForm deckForm = new DeckForm();
            deckForm.ShowDialog();
        }
    }
}
