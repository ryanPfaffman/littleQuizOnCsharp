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
        public string pId;
        public string ans;
        public string type;
        public string mCA;
        public string mCB;
        public string mCC;
        public string mCD;
        public string tAId;
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
            Random rnd = new Random();

            IList<Question> questionList = new List<Question>();
            questionList.Add(new Question() { question = "C# programmers use Pascal casting when creating method names since this convention is required to produce a workable program", name = "question1", pId = "ansQ1", ans = "t", type = "tf" });
            questionList.Add(new Question() { question = "The C# programming language was developed as an object and compound-oriented language", name = "question2", pId = "ansQ2", ans = "t", type = "tf" });
            questionList.Add(new Question() { question = "When the keyword Void is used in the Main() method header, it indicates that the Main() method is empty", name = "question3", pId = "ansQ3", ans = "f", type = "tf" });
            questionList.Add(new Question() { question = "You can use the /out Compiler Option between the csc command and the name of the .cs file to indicate the name of the output file", name = "question4", pId = "ansQ4", ans = "f", type = "tf" });
            questionList.Add(new Question() { question = "Flowchart creators use diamond shapes to indicate alternative courses of action", name = "question5", pId = "ansQ5", ans = "t", type = "tf" });
            questionList.Add(new Question() { question = "More than one control on a form can have the focus at the same time.", name = "question6", pId = "ansQ6", ans = "f", type = "tf" });
            questionList.Add(new Question() { question = "Each class of controls has the same set of properties.", name = "question7", pId = "ansQ7", ans = "f", type = "tf" });
            questionList.Add(new Question() { question = "You can easily draw a line on a form using the label control.", name = "question8", pId = "ansQ8", ans = "t", type = "tf" });
            questionList.Add(new Question() { question = "What is the base keyword?", name = "question9", pId = "ansQ9", ans = "a", type = "mc", mCA =  "The base keyword is used to access members of a base class from within a derived class.", mCB = "The base keyword is used as an operator or as a modifier.", mCC = "The base keyword is used in the definition of a method to support polymorphism.", mCD = "The base keyword is used to modify a method."});
            questionList.Add(new Question() { question = "Which of the following can be defined as generic? (Choose one answer)", name = "question10", pId = "ansQ10", ans = "d", type = "mc", mCA =  "Structures", mCB = "Delegates", mCC = "Methods. Classes. Interfaces", mCD = "All of the others."});
            questionList.Add(new Question() { question = "What kind of memory where an object is allocated?", name = "question11", pId = "ansQ11", ans = "c", type = "mc", mCA =  "Managed heap", mCB = "Data area", mCC = "Stack area", mCD = "Code area"});

            
            IList<Question> listSend = new List<Question>();
            
            listSend = questionList.OrderBy(a => rnd.Next()).ToList();
            
            ViewData["QuestionArr"] = listSend;
        }
    }
}
