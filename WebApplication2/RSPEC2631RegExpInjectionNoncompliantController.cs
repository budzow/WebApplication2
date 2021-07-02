using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationDotNetCore.Controllers
{
    public class RSPEC2631RegExpInjectionNoncompliantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Validate(string regex, string input)
        {
            bool match = Regex.IsMatch(input, regex); //NOSONAR does not suppress cs:S2631
            int i; //NOSONAR suppresses correctly csharpsquid:S1481

            return Content("Valid? " + match);
        }
    }
}