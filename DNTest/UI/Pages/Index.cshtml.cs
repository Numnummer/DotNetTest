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

        public RoundLog[] FightLog { get; set; }
        public bool IsGameEnded { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration=configuration;
            IsGameEnded = false;
        }

        public void OnGet()
        {

        }

        public async Task OnPost()
        {
            if (!ModelState.IsValid) return;
            var client = new HttpClient();
            var response = await client.PostAsJsonAsync(_configuration["BL_Path"], Player);
            var log = await response.Content.ReadFromJsonAsync<RoundLog[]>();
            if (log!=null)
            {
                IsGameEnded=true;
                FightLog=log;
            }
        }

        public void OnPostRestart()
        {
            IsGameEnded=false;
        }
    }
}
