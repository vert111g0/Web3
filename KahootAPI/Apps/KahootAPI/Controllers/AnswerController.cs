using KahootContracts.DTO;
using Microsoft.AspNetCore.Mvc;

namespace KahootAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        private readonly IAnswerRepository _answerRepository;

        public AnswerController (IAnswerRepository answerRepository)
        {
            _answerRepository = answerRepository;
        }
        
        [HttpGet("GetAllAnswers", Name = nameof(GetAllAnswers))]
        public List<Answer> GetAllAnswers()
        {
            return _answerRepository.GetAllAnswers();
        }

        [HttpGet("id/{ids}", Name = nameof(GetAnswersByQuestionId))]

        public IActionResult GetAnswersByQuestionId(int questionId)
        {
            var answers = _answerRepository.GetAnswersByQuestionId(questionId);
            return Ok(answers);
        }

        [HttpGet("id/{id}", Name = nameof(GetAnswerById))]
        public IActionResult GetAnswerById(int answerId)
        {
            var answer = _answerRepository.GetAnswerById(answerId);
            return Ok(answer);
        }

        [HttpGet("id/{AnswerId}", Name = nameof(GetAnswerByImg))]
        public IActionResult GetAnswerByImg(int imgId)
        {
            var answer = _answerRepository.GetAnswerByImage(imgId);
            return Ok(answer);
        }

        [HttpPost]
        public IActionResult AddAnswer(Answer answer) 
        {
            _answerRepository.AddAnswer(answer);
            return Ok();
        }
    }
}
