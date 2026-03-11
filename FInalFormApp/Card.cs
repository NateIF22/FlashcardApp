using System;
using System.Collections.Generic;
using System.Text;

namespace FinalFormApp
{
    public class Card
    {
        public string Title { get; set; }
        public string Question { get; set; }
        public string QuestionNote { get; set; }
        public string AnswerNote { get; set; }
        public string Answer { get; set; }
     
        public Card(string title, string question, string answer, string question_note, string answer_note)
        {
            Title = title;
            Question = question;
            Answer = answer;
            QuestionNote = question_note;
            AnswerNote = answer_note;
                
        }

        public Card() 
        {
            Title = string.Empty;
            Question = string.Empty;
            Answer = string.Empty;
            QuestionNote = string.Empty;
            AnswerNote = string.Empty;
        }


    }
}
