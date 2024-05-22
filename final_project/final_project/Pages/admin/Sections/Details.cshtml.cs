﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using final_project.Data;
using final_project.Models;

namespace final_project.Pages.admin.Sections
{
    public class DetailsModel : PageModel
    {
        private readonly final_project.Data.ApplicationDbContext _context;

        public DetailsModel(final_project.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Section Section { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var section = await _context.Section.FirstOrDefaultAsync(m => m.Id == id);
            if (section == null)
            {
                return NotFound();
            }
            else
            {
                Section = section;
            }
            return Page();
        }
    }
}