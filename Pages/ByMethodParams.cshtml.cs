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
        public IActionResult OnPost(string name, string email, string message) 
        {
            if (ModelState.IsValid)
            {
                using (var dbContext = new ScrapBookDBContext())
                {
                    var scrap = new Scrap() 
                    {
                        Name = name,
                        Email = email,
                        Message = message
                    };

                    dbContext.Scraps.Add(scrap);

                    dbContext.SaveChanges();

                    return RedirectToPage("Index");
                }
            }
            else
            {
                return Page();
            }
        }
    }
}