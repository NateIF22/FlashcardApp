using FinalFormApp;
using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace FInalFormApp
{

    public partial class Form1 : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<Deck> Decks { get; set; }

        public BindingSource deckBindingSource;
        public Form1()
        {
            InitializeComponent();
            Decks = new BindingList<Deck>();
            deckBindingSource = new BindingSource();
            deckBindingSource.DataSource = Decks;

            deckBindingSource.ListChanged += DeckBindingSource_CurrentChanged;

        }

        // Event handler for when the current items in the Bindingsource changes
        private void DeckBindingSource_CurrentChanged(object? sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                Deck deck = Decks[e.NewIndex];
                AddDeckControl(deck);
            }
            else if (e.ListChangedType == ListChangedType.ItemDeleted)
            {
                lvDecks.Controls.Clear();
                foreach (Deck deck in Decks)
                {
                    AddDeckControl(deck);
                }
            }
        }

        // Adds a deck control to the list view for the inputed deck
        private void AddDeckControl(Deck deck)
        {
            var item = new DeckControl(deck, Decks);
            lvDecks.Controls.Add(item);
        }

        private void btnNewDeck_Click(object sender, EventArgs e)
        {
            // Logic to add a new deck to the list box
            DeckCreateForm deckForm = new DeckCreateForm(null);
            if (deckForm.ShowDialog() == DialogResult.OK)
            {
                // adds a new deck to the list of decks
                Decks.Add(deckForm.GetDeck());
            }
        }
    }
}
