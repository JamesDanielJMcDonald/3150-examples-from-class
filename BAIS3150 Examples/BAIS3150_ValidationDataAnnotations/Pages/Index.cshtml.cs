using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;

namespace BAIS3150_ValidationDataAnnotations.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string Message { get; set; }

        [BindProperty]
        [Required]
        public string Field { get; set; }

        [Remote(action: "VerifyInput", controller: "Users", HttpMethod = "Post")]
        [BindProperty]
        public string ValidateMe { get; set; }

        public void OnGet()
        {
            Message = "*** OnGet() ***";
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                Message = "*** OnPost() *** - Valid";
            }
            else
            {
                Message = "*** OnPost() *** - Not Valid";
            }
        }
    }
}
