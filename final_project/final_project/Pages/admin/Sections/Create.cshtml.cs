using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using final_project.Data;
using final_project.Models;

namespace final_project.Pages.admin.Sections
{
    public class CreateModel : PageModel
    {
        private readonly final_project.Data.ApplicationDbContext _context;

        public CreateModel(final_project.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Section Section { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Section.Add(Section);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
