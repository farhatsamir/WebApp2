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
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Carousel> Carousel { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Carousel = await _context.Carousel.ToListAsync();
        }
    }
}
