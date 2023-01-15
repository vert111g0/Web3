namespace KahootInfrastructure.Model
{
    public class Answer
    {
        public int Id { get; set; }
        public int Image { get; set; }

        public bool IsCorrect { get; set; }
        public string Description { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}