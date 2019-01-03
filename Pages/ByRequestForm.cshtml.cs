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
        public async Task<IActionResult> OnPost() {
            if (ModelState.IsValid)
            {
                using (var dbContext = new ScrapBookDBContext())
                {
                    var scrap = new Scrap() { 
                        Name = Request.Form["name"],
                        Email = Request.Form["email"],
                        Message = Request.Form["message"] 
                    };
    
                    dbContext.Add(scrap);
    
                    await dbContext.SaveChangesAsync();
    
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