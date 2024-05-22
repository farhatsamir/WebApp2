using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using final_project.Models;
using final_project.Data;

namespace final_project.Pages.admin.Carousels
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Carousel Carousel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carousel = await _context.Carousel.FirstOrDefaultAsync(m => m.Id == id);

            if (carousel == null)
            {
                return NotFound();
            }
            else
            {
                Carousel = carousel;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carousel = await _context.Carousel.FindAsync(id);
            if (carousel != null)
            {
                Carousel = carousel;
                _context.Carousel.Remove(Carousel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
