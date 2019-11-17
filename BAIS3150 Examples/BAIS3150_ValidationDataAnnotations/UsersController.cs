using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BAIS3150_ValidationDataAnnotations
{
    public class UsersController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        // dynamically called from the form
        [AcceptVerbs("Get", "Post")]
        public IActionResult VerifyInput(string validateMe)
        {
            if (validateMe == "bob")
            {
                return Json($"Name {validateMe} is already in use.");
            }
            return Json(true);
        }
    }
}
