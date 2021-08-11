using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesExample.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        public string Sorry { get; set; }

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {   
            _logger = logger;
        }

        public void OnGet()
        {
            Sorry = "Sorry, this is a simple example. We did not create a privacy policy.";
        }
    }
}
