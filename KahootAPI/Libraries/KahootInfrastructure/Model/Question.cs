using System.ComponentModel.DataAnnotations.Schema;

namespace KahootInfrastructure.Model
{
    public class Question
    {
        public int Id { get; set; } 
        public string Description { get; set; }
        
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }
        
        public ICollection<Answer> Answers { get; set; } 
        
        
    }
}