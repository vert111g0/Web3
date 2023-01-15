using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahootContracts.DTO
{
    public class Question 
    {
        public Question() { }

        public int Id { get; set; }
        public string Description { get; set; }

        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }

        public ICollection<Answer> Answers { get; set; }

    }
}
