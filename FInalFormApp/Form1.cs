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

        // Event handler for when the current items in the BindingSource changes
        private void DeckBindingSource_CurrentChanged(object? sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                Deck deck = Decks[e.NewIndex];
                AddDeckControl(deck);
            }
            else if (e.ListChangedType == ListChangedType.ItemDeleted)
            {
                fpDecks.Controls.Clear();
                foreach (Deck deck in Decks)
                {
                    AddDeckControl(deck);
                }
            }
            {
                
            }
            {

            }
        }

        private void AddDeckControl(Deck deck)
        {
            var item = new DeckControl(deck);
            fpDecks.Controls.Add(item);
        }

        public void UpdateDecks()
        {
            fpDecks.Controls.Clear();
            foreach (Deck deck in Decks)
            {
                fpDecks.Controls.Add(new DeckControl(deck));
            }
        }

        public void AddDeck(
            string category,
            string name
            )
        {
            Decks.Add(new Deck
            {
                Category = category,
                Name = name
            });
        }

        public void AddDeck(Deck deck)
        {
            Decks.Add(deck);
        }

        private void UpdateDeckList()
        {
            fpDecks.Controls.Clear();
            foreach (Deck deck in Decks)
            {
                fpDecks.Controls.Add(new DeckControl(deck));
            }
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
