using System;
using System.Collections.Generic;
using System.Text;

namespace FinalFormApp
{
    internal class Validators
    {

        // Validates that the input is not null or whitespace and returns a bool.
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
