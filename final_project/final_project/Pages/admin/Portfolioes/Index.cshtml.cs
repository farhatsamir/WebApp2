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
    public class IndexModel : PageModel
    {
        private readonly final_project.Data.ApplicationDbContext _context;

        public IndexModel(final_project.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Portfolio> Portfolio { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Portfolio = await _context.Portfolio.ToListAsync();
        }
    }
}
