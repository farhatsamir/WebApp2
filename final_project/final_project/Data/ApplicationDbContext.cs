using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using final_project.Models;

namespace final_project.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<final_project.Models.Carousel> Carousel { get; set; } = default!;
        public DbSet<final_project.Models.Service> Service { get; set; } = default!;
        public DbSet<final_project.Models.Section> Section { get; set; } = default!;
        public DbSet<final_project.Models.Portfolio> Portfolio { get; set; } = default!;
        public DbSet<final_project.Models.Product> Product { get; set; } = default!;
        public DbSet<final_project.Models.Message> Message { get; set; } = default!;

    }
}
