using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesExample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string Message { get; set; } = "Hello, User X! ";

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
 
        public void OnGet()
        {
            _logger.LogInformation("Started a Razor pages web application");
            Message += $"We just modified the message property upon your GET request.";
        }
    }
}
