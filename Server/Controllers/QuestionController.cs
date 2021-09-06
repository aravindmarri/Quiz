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
            Question[] Questions = new Question[] { new Question { QuestionsData = "Which of the following is a reserved keyword in C#?", OptionsData = new List<string> { "abstract", "foreach", "as", "info" } },
                                                 new Question { QuestionsData = " CLR is the .Net equivalent of _____", OptionsData = new List<string> { "Java Virtual machine", "Common Language Runtime", "Common Type System", "Common Language Specification" } },
                                                 new Question { QuestionsData = "The space required for structure variables is allocated on the stack.", OptionsData = new List<string> { "True", "False", "May be", "Can’t say" } },
                                                 new Question { QuestionsData = "Abstract class contains _____", OptionsData = new List<string> { "Abstract methods", "Non Abstract methods", "Static methods", "Void methods" } }
                };
            return Questions;
        }
    }
}
