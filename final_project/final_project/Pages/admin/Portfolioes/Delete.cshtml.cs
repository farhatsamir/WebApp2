using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using final_project.Data;
using final_project.Models;

namespace final_project.Pages.admin.Portfolioes
{
    public class DeleteModel : PageModel
    {
        private readonly final_project.Data.ApplicationDbContext _context;

        public DeleteModel(final_project.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Portfolio Portfolio { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var portfolio = await _context.Portfolio.FirstOrDefaultAsync(m => m.Id == id);

            if (portfolio == null)
            {
                return NotFound();
            }
            else
            {
                Portfolio = portfolio;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var portfolio = await _context.Portfolio.FindAsync(id);
            if (portfolio != null)
            {
                Portfolio = portfolio;
                _context.Portfolio.Remove(Portfolio);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
