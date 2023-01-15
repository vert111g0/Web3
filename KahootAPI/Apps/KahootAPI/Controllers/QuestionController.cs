using KahootContracts.DTO;
using Microsoft.AspNetCore.Mvc;

namespace KahootAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionController(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        [HttpGet("GetAllQuestions", Name = nameof(GetAllQuestions))]
        public IActionResult GetAllQuestions() 
        { 
            var questions = _questionRepository.GetAllQuestions();
            return Ok(questions);
        }

        [HttpGet("questions/{id}", Name = nameof(GetQuestionById))]
        public IActionResult GetQuestionById(int id)
        {
            var question = _questionRepository.GetQuestionById(id);
            return Ok(question);
        }

        [HttpGet("questions/{quizId}", Name = nameof(GetQuestionsForQuizId))]
        public IActionResult GetQuestionsForQuizId(int quizId)
        {
            var questions = _questionRepository.GetAllQuestionsForQuizId(quizId);
            return Ok(questions);
        }

        [HttpPost]
        public IActionResult CreateQuestion(Question question) 
        { 
            _questionRepository.CreateQuestion(question);
            return Ok();
        }

    }
}
