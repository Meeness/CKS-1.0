using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using CKS_1._0.Model;

namespace CKS_1._0.Pages
{
    public class DeviceSettingsModel : PageModel
    {
        private readonly ILogger<DeviceSettingsModel> _logger;
        public CombatKarts CK = CombatKarts.Instance;

        public DeviceSettingsModel(ILogger<DeviceSettingsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
        }
        
    }
}
