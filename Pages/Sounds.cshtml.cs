using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CKS_1._0.Pages
{
    public class SoundsModel : PageModel
    {
        private readonly ILogger<SoundsModel> _logger;

        public SoundsModel(ILogger<SoundsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
