namespace KahootInfrastructure.Model
{
    public class Topic
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public ICollection<Quiz> Quizes { get; set; }
    }
}