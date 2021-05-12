using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CKS_1._0.Model;

namespace CKS_1._0.Pages
{
    public class GameSettingsModel : PageModel
    {
        private readonly ILogger<GameSettingsModel> _logger;
        public CombatKarts CK = CombatKarts.Instance;

        public GameSettingsModel(ILogger<GameSettingsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        protected void TeamSelect(object sender, EventArgs e)
        {
            
            //CK.ActiveGame.ChangeTeam(Player, IDictionary?, anotherid?);
        }
    }
}
