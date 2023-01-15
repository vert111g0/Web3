using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahootContracts.DTO
{
    public interface IQuestionRepository
    {
        Question GetQuestionById(int id);

        List<Question> GetAllQuestions();

        List<Question> GetAllQuestionsForQuizId(int quizId);

        void CreateQuestion(Question question);

        void SaveChanges();

    }
}
