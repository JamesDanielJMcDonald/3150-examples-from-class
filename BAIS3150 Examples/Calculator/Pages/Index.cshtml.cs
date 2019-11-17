using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Calculator.Pages
{
    public class IndexModel : PageModel
    {
        // BindProperty wires stuff up
        [BindProperty]
        public int First { get; set; }
        [BindProperty]
        public int Second { get; set; }
        [BindProperty]
        public string calcResult { get; set; }
        // TempData encapsulates local data, the user won't see it (won't be pushed back to the form)
        [TempData]
        public int IntegerResult { get; set; }
        public void OnGet()
        {

        }

        public void OnPost()
        {
            IntegerResult = First + Second;

            calcResult = IntegerResult.ToString();
        }
    }
}
