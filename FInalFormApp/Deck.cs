using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FlashcardApp
{
    public class Deck
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public BindingList<Card> Cards { get; set; }
        public int CardCount { set; get; }

        public Deck()
        {
            Cards = new BindingList<Card>();
            Name = string.Empty;
            Category = string.Empty;
            
        }
    }
}
