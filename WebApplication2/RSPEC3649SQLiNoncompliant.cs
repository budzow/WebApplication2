using System;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationDotNetCore.Controllers
{
    public class RSPEC2083IOInjectionNoncompliantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DeleteFile(string fileName)
        {
            System.IO.File.Delete(fileName); //NOSONAR does not suppress cs:S2083
            int i; //NOSONAR suppresses correctly csharpsquid:S1481

            return Content("File " + fileName + " deleted");
        }
    }
}