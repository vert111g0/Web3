using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahootContracts.DTO
{
    public interface ITopicRepository
    {

        Topic GetByTopicId(int id);

        List <Topic> GetAllTopics();
        void CreateTopic(Topic topic);
        void SaveChanges();
    }
}
