using System;
using System.Collections.Generic;
using System.Text;

namespace FlashcardApp
{
    public class Card
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string QuestionNote { get; set; }
        public string AnswerNote { get; set; }
        public string Answer { get; set; }
     
        public Card(int id, string question, string answer, string question_note, string answer_note)
        {
            Id = id;
            Question = question;
            Answer = answer;
            QuestionNote = question_note;
            AnswerNote = answer_note;
                
        }

        public Card() 
        {
            Id = 0;
            Question = string.Empty;
            Answer = string.Empty;
            QuestionNote = string.Empty;
            AnswerNote = string.Empty;
        }


    }
}
