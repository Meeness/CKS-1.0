using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CKS_1._0.Pages
{
    public class DMModel : PageModel
    {
        private readonly ILogger<DMModel> _logger;

        public DMModel(ILogger<DMModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
