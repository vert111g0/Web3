using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahootDomain.Models
{
    public class Question 
    {
        public Question() { }

        public Question(string question, List<Answer> answer, Quiz quiz)
        {
            Description= question;
            Answers= answer;
            Quiz= quiz;
            QuizId = quiz.Id;
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }

        public ICollection<Answer> Answers { get; set; }

    }
}
