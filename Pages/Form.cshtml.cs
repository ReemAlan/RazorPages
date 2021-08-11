using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesExample.Pages
{
    public class FormModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Age { get; set; }
        [BindProperty]
        public string EmailAddress { get; set; }
        [BindProperty]
        public DateTime? BirthDate { get; set; }
        public bool IsSubmitted { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
        }
    }
}
