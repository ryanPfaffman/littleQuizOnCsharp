using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace quizGui.Pages
{

    public class Question
    {
        public string question;
        public string name;
    }

    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Question question = new Question();

            IList<Question> questionList = new List<Question>();
            questionList.Add(new Question() { question = "C# programmers use Pascal casting when creating method names since this convention is required to produce a workable program", name = "question1" });
            questionList.Add(new Question() { question = "The C# programming language was developed as an object and compound-oriented language", name = "question2" });
            questionList.Add(new Question() { question = "When the keyword Void is used in the Main() method header, it indicates that the Main() method is empty", name = "question3" });
            questionList.Add(new Question() { question = "You can use the /out Compiler Option between the csc command and the name of the .cs file to indicate the name of the output file", name = "question4" });
            questionList.Add(new Question() { question = "Flowchart creators use diamond shapes to indicate alternative courses of action", name = "question5" });

            ViewData["QuestionArr"] = questionList;

        }
    }
}
