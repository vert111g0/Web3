using KahootContracts.DTO;
using KahootInfrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace KahootInfrastructure.Repositories
{
    public class EFQuestionRepository : IQuestionRepository
    {
        private readonly KahootContext _dbContext;
        private readonly DbSet<KahootContracts.DTO.Question> _questions;

        public EFQuestionRepository(KahootContext dbContext)
        {
            _dbContext = dbContext;
            _questions = _dbContext.Questions;
        }

        public KahootContracts.DTO.Question GetQuestionById(int id )
        {
            return _questions.FirstOrDefault( q => q.Id == id );
        }


        public List<KahootContracts.DTO.Question> GetAllQuestions()
        {
            return _questions.ToList();
        }

        public List<KahootContracts.DTO.Question> GetAllQuestionsForQuizId(int quizId )
        {
            return _questions.Where(i => quizId== i.QuizId).ToList();
        }

        public void CreateQuestion(Question question)
        {
            _questions.Add(question);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

    }
}
