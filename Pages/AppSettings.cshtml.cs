using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CKS_1._0.Pages
{
    public class AppSettingsModel : PageModel
    {
        private readonly ILogger<AppSettingsModel> _logger;

        public AppSettingsModel(ILogger<AppSettingsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
