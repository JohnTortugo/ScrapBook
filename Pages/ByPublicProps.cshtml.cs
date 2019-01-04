using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ScrapBook.Pages
{
    public class ByPublicPropsModel : PageModel
    {
        [BindProperty]
        public string name { get; set; }

        [BindProperty]
        public string email { get; set; }

        [BindProperty]
        public string message { get; set; }

        private ScrapBookDBContext DbContext;

        public ByPublicPropsModel(ScrapBookDBContext dbContext)
        {
            DbContext = dbContext;
        }

        public IActionResult OnPost() 
        {
            if (ModelState.IsValid) 
            {
                var scrap = new Scrap() {
                    Name = name,
                    Email = email,
                    Message = message
                };

                DbContext.Scraps.Add(scrap);
                DbContext.SaveChanges();

                return RedirectToPage("Index");
            }
            else {
                return Page();
            }
        }
    }
}