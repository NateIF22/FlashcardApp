using System;
using System.Collections.Generic;
using System.Text;

namespace FinalFormApp
{
    internal class Validators
    {
        public bool ValidateDeck(Deck deck)
        {
            if (string.IsNullOrWhiteSpace(deck.Name))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(deck.Category))
            {
                return false;
            }
            if (deck.Cards == null || deck.Cards.Count == 0)
            {
                return false;
            }
            return true;
        }
    }
}
