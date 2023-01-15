using KahootContracts.DTO;
using KahootInfrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace KahootInfrastructure.Repositories
{
    public class EFAnswerRepository : IAnswerRepository
    {
        private readonly KahootContext _dbContext;
        private readonly DbSet<KahootContracts.DTO.Answer> _answers;

        public EFAnswerRepository(KahootContext dbContext)
        {
            _dbContext = dbContext;
            _answers = _dbContext.Answers;
        }
        public List<KahootContracts.DTO.Answer> GetAllAnswers()
        {
            return _answers.ToList();
        }
        public KahootContracts.DTO.Answer GetAnswerById(int id)
        {
            return _answers.FirstOrDefault(i => i.Id == id);
        }

        public KahootContracts.DTO.Answer GetAnswerByImage(int imagePosition)
        {
            return _answers.FirstOrDefault(i => i.Image == imagePosition);
        }
        public List<KahootContracts.DTO.Answer> GetAnswersByQuestionId(int id)
        {
            return _answers.Where(q =>q.QuestionId == id).ToList();

        }
        public void AddAnswer(Answer answer)
        {
            _answers.Add(answer);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

    }
}
