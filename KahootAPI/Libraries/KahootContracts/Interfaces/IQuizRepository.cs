using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahootContracts.DTO
{
    public interface IQuizRepository
    {
        Quiz GetQuizById(int id);

        List<Quiz> GetQuizesByTopicId(int id); 

        List<Quiz> GetAllQuizes();

        List <Question> GetAllQuestionsForQuiz(int quizId );

        //List<User> GetAllUsersForQuiz(Quiz quiz );

        void CreateQuiz(Quiz quiz);

        void SaveChanges();
    }
}
