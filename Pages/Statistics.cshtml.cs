using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CKS_1._0.Pages
{
    public class StatisticsModel : PageModel
    {
        private readonly ILogger<StatisticsModel> _logger;

        public StatisticsModel(ILogger<StatisticsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
