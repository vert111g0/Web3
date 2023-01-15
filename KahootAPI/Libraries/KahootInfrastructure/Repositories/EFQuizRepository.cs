using KahootContracts.DTO;
using KahootInfrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace KahootInfrastructure.Repositories
{
    public class EFQuizRepository : IQuizRepository
    {
        private readonly KahootContext _dbContext;
        private readonly DbSet<KahootContracts.DTO.Quiz> _quizes;

        public EFQuizRepository(KahootContext dbContext)
        {
            _dbContext = dbContext;
            _quizes = _dbContext.Quizes;
        }

        public List<KahootContracts.DTO.Quiz> GetAllQuizes()
        {
            return _quizes.ToList();
        }

        public KahootContracts.DTO.Quiz GetQuizById( int id)
        {
            return _quizes.FirstOrDefault(i => i.Id == id);
        }

        public List<KahootContracts.DTO.Quiz> GetQuizesByTopicId(int topicId )
        {
            return _quizes.Where(i => i.TopicId == topicId).ToList();
        }

        public List<KahootContracts.DTO.Question> GetAllQuestionsForQuiz( int quizId )
        {
            return _dbContext.Questions.Where(i => quizId== i.QuizId).ToList();

        }

        public void CreateQuiz(Quiz quiz)
        {
            _dbContext.Quizes.Add(quiz);
            _dbContext.SaveChanges();
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

    }
}
