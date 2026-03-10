using System;
using System.Collections.Generic;
using System.Text;

namespace FinalFormApp
{
    public class Card
    {
        public string Title { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Notes { get; set; }
     
        public Card(string title, string question, string answer, string notes)
            {
                Title = title;
                Question = question;
                Answer = answer;
                Notes = notes;
        }

        public Card() 
        {
            Title = string.Empty;
            Question = string.Empty;
            Answer = string.Empty;
            Notes = string.Empty;
        }


    }
}
