using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages
{
    public class CategoriesModel : PageModel
    {
        public List<Category> CategoryList { get; set; } = new();
        public void OnGet()
        {
            for (var i = 0; i < 100; i++)
            {
                CategoryList.Add(
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
