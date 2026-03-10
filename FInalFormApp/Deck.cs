using System;
using System.Collections.Generic;
using System.Text;

namespace FinalFormApp
{
    public class Deck
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public List<Card> Cards { get; set; }

        public Deck(string name, string category)
        {
            Name = name;
            Category = category;
            Cards = new List<Card>();
        }
        public Deck()
        {
            Cards = new List<Card>();
            Name = string.Empty;
            Category = string.Empty;
        }

    }
}
