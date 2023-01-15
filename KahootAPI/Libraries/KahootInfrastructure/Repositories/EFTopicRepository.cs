using KahootContracts.DTO;
using KahootInfrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace KahootInfrastructure.Repositories
{
    public class EFTopicRepository : ITopicRepository
    {
        private readonly KahootContext _dbContext;
        private readonly DbSet<KahootContracts.DTO.Topic> _topics;

        public EFTopicRepository(KahootContext dbContext)
        {
            _dbContext = dbContext;
            _topics = _dbContext.Topics;
        }

        public List<Topic> GetAllTopics()
        {
            return _topics.ToList();
        }

        public Topic GetByTopicId(int id)
        {
            return _topics.FirstOrDefault(i => i.Id == id);
        }

        public void CreateTopic(Topic topic)
        {
            _topics.Add(topic);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
