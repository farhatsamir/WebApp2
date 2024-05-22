using Elfie.Serialization;
using final_project.Data;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;

namespace final_project.Pages
{
    public class globals
    {
        public List<final_project.Models.Section> active_list;
        public globals()
        {
            
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=aspnet-final_project;
            Trusted_Connection=True;MultipleActiveResultSets=true")
                    .Options;

            ApplicationDbContext context = new ApplicationDbContext(contextOptions);
            var results_list = context.Section;
            // LinQ C# technology
            active_list = (from item in results_list
                                where item.active == true
                                orderby item.order ascending  /* or descending */
                                select item).ToList();

        }
    }
}
