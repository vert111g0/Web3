using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahootContracts.DTO
{
    public interface IAnswerRepository
    {
        List<Answer> GetAllAnswers();
        Answer GetAnswerById(int id);

        Answer GetAnswerByImage(int image);

        List<Answer> GetAnswersByQuestionId(int questionId);

        void AddAnswer(Answer answer);

        void SaveChanges();
    }
}
