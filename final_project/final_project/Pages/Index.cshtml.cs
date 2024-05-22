using final_project.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;


namespace final_project.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost(string data1, string data2)
        {
            Models.Message msg1 = new Models.Message();

            msg1.client_email = data1;
            msg1.client_message = data2;
            msg1.message_data = DateTime.Today.ToString();

            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
           .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=aspnet-final_project;
                Trusted_Connection=True;MultipleActiveResultSets=true")
           .Options;

            ApplicationDbContext context = new ApplicationDbContext(contextOptions);

            context.Message.Add(msg1);
            context.SaveChanges();

        }

    }
}
