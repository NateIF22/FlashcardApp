using System;
using System.Collections.Generic;
using System.Text;

namespace FlashcardApp
{
    internal class Validators
    {
        public static bool IsPresent(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
