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
    public class ScoreboardModel : PageModel
    {
        private readonly ILogger<ScoreboardModel> _logger;
        public CombatKarts CK = CombatKarts.Instance;
        public ScoreboardModel(ILogger<ScoreboardModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
        }
        public IActionResult OnPost(){
            //game duration
            var gameduration = Request.Form["gameduration"];
            if(gameduration.Count>0){
                CK.ActiveGame.GameDuration = Convert.ToInt32(gameduration);
            }
            //game delay
            var gamedelay = Request.Form["gamedelay"];
            if(gamedelay.Count>0){
                CK.ActiveGame.GameDelay = Convert.ToInt32(gamedelay);
            }
            //game start & stop
            var gamestart = Request.Form["gamestart"];
            var gamestop = Request.Form["gamestop"];
            var gameready = Request.Form["gameready"];

            if((String)gamestart!=null){
                CK.ActiveGame.StartGame(CK.wifiHandler);
            }else if((String)gamestop!=null){
                CK.ActiveGame.EndGame(CK.wifiHandler);
            }else if((String)gameready!=null){
                CK.NewGame();
            }

            //testmode engage
            var testmode = Request.Form["testmode"];
            if(testmode.Count>0){
                CK.CreatePlayerTest();
            }

            return Page();
        }
    }
}
