using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SportsStoreMVC.Pages
{
    public class CompletedModel : PageModel
    {
        [BindProperty]
        public int OrderId { get; set; }
        public void OnGet()
        {
             
        }
    }
}