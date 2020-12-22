using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace quizGui.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            /*
            ViewData["Question1"] = new Question {
                Question = "\nC# programmers use Pascal casting when creating method names since this convention is required to produce a workable program\n\tA. True\n\tB. False",
                Answer = "a"
            };
            ViewData["Question2"] = new Question {
                Question = "\nThe C# programming language was developed as an object and compound-oriented language\n\tA. True\n\tB. False",
                Answer = "a"
            };
            ViewData["Question3"] = new Question {
                Question = "\nWhen the keyword Void is used in the Main() method header, it indicates that the Main() method is empty\n\tA. True\n\tB. False",
                Answer = "b"
            };
            ViewData["Question4"] = new Question {
                Question = "\nYou can use the /out Compiler Option between the csc command and the name of the .cs file to indicate the name of the output file\n\tA. True\n\tB. False",
                Answer = "b"
            };
            ViewData["Question5"] = new Question {
                Question = "\nFlowchart creators use diamond shapes to indicate alternative courses of action\n\tA. True\n\tB. False",
                Answer = "a"
            };
            */

            ViewData["Question1"] = "C# programmers use Pascal casting when creating method names since this convention is required to produce a workable program";
            ViewData["Question2"] = "The C# programming language was developed as an object and compound-oriented language";
            ViewData["Question3"] = "When the keyword Void is used in the Main() method header, it indicates that the Main() method is empty";
            ViewData["Question4"] = "You can use the /out Compiler Option between the csc command and the name of the .cs file to indicate the name of the output file";
            ViewData["Question5"] = "Flowchart creators use diamond shapes to indicate alternative courses of action";

        }
    }
}
