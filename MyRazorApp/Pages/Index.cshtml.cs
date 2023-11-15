using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages
{
    public class IndexModel : PageModel
    {
        public List<Category> Categories { get; set; } = new();
        public async Task OnGet()
        {
           // await Task.Delay(5000);

            for(var i = 0;  i < 100; i++) 
            {
                Categories.Add(
                    new Category(
                        i,
                        $"Category {i}",
                        1 * 18.25M
                        )
                    );
            }
        }
    }

    public record Category(
        int Id,
        string Title,
        decimal Price
    );
}
