using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ScrapBook.Pages
{
    public class ByMethodParamsModel : PageModel
    {
        private ScrapBookDBContext DbContext;

        public ByMethodParamsModel(ScrapBookDBContext dbContext)
        {
            DbContext = dbContext;
        }

        public IActionResult OnPost(string name, string email, string message) 
        {
            if (ModelState.IsValid)
            {
                var scrap = new Scrap() 
                {
                    Name = name,
                    Email = email,
                    Message = message
                };

                DbContext.Scraps.Add(scrap);
                DbContext.SaveChanges();

                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}