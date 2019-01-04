using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ScrapBook.Pages
{
    public class ByRequestFormModel : PageModel
    {
        private ScrapBookDBContext DbContext;

        public ByRequestFormModel(ScrapBookDBContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<IActionResult> OnPost() {
            if (ModelState.IsValid)
            {
                var scrap = new Scrap() { 
                    Name = Request.Form["name"],
                    Email = Request.Form["email"],
                    Message = Request.Form["message"] 
                };

                DbContext.Add(scrap);
                await DbContext.SaveChangesAsync();

                return RedirectToPage("Index");
        }
            else
            {
                return Page();
            }
        }
    }
}