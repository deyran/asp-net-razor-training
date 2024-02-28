using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
	public class IndexModel : PageModel
	{
        /*private readonly ILogger<IndexModel> _logger;

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{

		}*/

        public List<Category> Categories { get; set; } = new List<Category>();

        public async Task OnGet()
		{			
			await Task.Delay(5000);

            for (var i = 0; i <= 100; i++)
            {
                Categories.Add(
                    new Category(
                        i,
                        $"Categoria {i}",
                        i * 18.95M
                    )
                );
            }

        }
    }

	public record Category(int Id, string Title, decimal Price);

}
