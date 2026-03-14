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
                lvDecks.Controls.Clear();
                foreach (Deck deck in Decks)
                {
                    AddDeckControl(deck);
                }
            }
        }

        private void AddDeckControl(Deck deck)
        {
            var item = new DeckControl(deck);
            lvDecks.Controls.Add(item);
        }

        public void UpdateDecks()
        {
            lvDecks.Controls.Clear();
            foreach (Deck deck in Decks)
            {
                lvDecks.Controls.Add(new DeckControl(deck));
            }
        }

        private void btnNewDeck_Click(object sender, EventArgs e)
        {
            // Logic to add a new deck to the list box
            // Add the DeckForm for creating a new deck
            DeckCreateForm deckForm = new DeckCreateForm(null);
            if (deckForm.ShowDialog() == DialogResult.OK)
            {
                // ands a new deck to the list of decks
                Decks.Add(deckForm.GetDeck());


            }
        }

        //private void btnEditDeck_Click(object sender, EventArgs e)
        //{
        //    // When edit is clicked, open the card edit form
        //    // Checks of the selected 
        //    if (deckBindingSource.Current is Deck selectedDeck)
        //    {
        //        CardEditForm form = new CardEditForm(selectedDeck);
        //        if (form.ShowDialog() == DialogResult.OK) 
        //        {
        //            //If the cards change, refresh the ui
        //            UpdateDecks();
        //        }
        //    }

        //}
    }
}
