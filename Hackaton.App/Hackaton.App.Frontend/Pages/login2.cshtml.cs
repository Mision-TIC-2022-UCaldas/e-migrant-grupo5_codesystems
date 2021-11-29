using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Hackaton.App.Frontend.Pages
{
    public class loginModel : PageModel
    {
        private readonly ILogger<loginModel> _logger;

        public loginModel(ILogger<loginModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}