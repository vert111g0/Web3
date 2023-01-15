using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahootDomain.Models
{
    public class Answer 
    {
        public Answer() { }

        public Answer(Question question, string answer, bool isCorrect)
        {
            Question= question;
            Description= answer;
            IsCorrect= isCorrect;
            QuestionId= question.Id;
        }
        public int Id { get; set; }
        public int Image { get; set; }

        public bool IsCorrect { get; set; }
        public string Description { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }

    }
}
