using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages
{
    public class CategoriesModel : PageModel
    {
        public List<Category> CategoryList { get; set; } = new();
        public void OnGet(
                int skip = 0, 
                int take = 25)
        {
            var temp = new List<Category>();
            for (var i = 0; i < 1787; i++)
            {
                temp.Add(
                    new Category(
                        i,
                        $"Category {i}",
                        1 * 18.25M
                        )
                    );
            }

            CategoryList = temp
                    .Skip(skip)
                    .Take(take)
                    .ToList();

        }
    }

    public record Category(
        int Id,
        string Title,
        decimal Price
    );

}
