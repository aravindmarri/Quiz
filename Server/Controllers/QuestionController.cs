using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuizWebApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizWebApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<QuestionController> _logger;

        public QuestionController(ILogger<QuestionController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Question> Get()
        {
            Question[] Questions = new Question[] { new Question { QuestionsData = "Question1", OptionsData = new List<string> { "a", "b", "c", "d" } },
                                                 new Question { QuestionsData = "Question2", OptionsData = new List<string> { "a", "b", "c", "d" } },
                                                 new Question { QuestionsData = "Question3", OptionsData = new List<string> { "a", "b", "c", "d" } },
                                                 new Question { QuestionsData = "Question4", OptionsData = new List<string> { "a", "b", "c", "d" } }
                };
            return Questions;
        }
    }
}
