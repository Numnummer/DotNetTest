using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration _configuration;

        [BindProperty]
        public Player Player { get; set; }

        public RoundLogDto[]? FightLog { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration=configuration;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();
            var client = new HttpClient();
            var response = await client.PostAsJsonAsync(_configuration["BL_Path"], Player);
            FightLog = await response.Content.ReadFromJsonAsync<RoundLogDto[]>();
            return Page();
        }

    }
}
