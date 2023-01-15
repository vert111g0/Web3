using KahootContracts.DTO;
using Microsoft.AspNetCore.Mvc;

namespace KahootAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly IQuizRepository _quizRepository;

        public QuizController(IQuizRepository quizRepository)
        {
            _quizRepository = quizRepository;
        }

        [HttpGet("GetAllQuizes", Name = nameof(GetAllQuizes))]
        public IActionResult GetAllQuizes()
        {
            var quizes = _quizRepository.GetAllQuizes();
            return Ok(quizes);
        }

        [HttpGet("id", Name = nameof(GetQuizById))]
        public IActionResult GetQuizById(int id) 
        {
            var quiz = _quizRepository.GetQuizById(id);
            return Ok(quiz);
        }

        [HttpGet("quiz/{TopicId}", Name = nameof(GetQuizByTopicId))]
        public IActionResult GetQuizByTopicId(int topicId)
        {
            var quizes = _quizRepository.GetQuizesByTopicId(topicId);
            return Ok(quizes);
        }

        [HttpPost]
        public IActionResult CreateQuiz(Quiz quiz)
        {
            _quizRepository.CreateQuiz(quiz);
            return Ok(quiz);
        }
    }
}
