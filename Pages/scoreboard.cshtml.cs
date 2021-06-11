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
            //teamselect
            var teamselect = Request.Form["teamselect"];
            if((teamselect!=""&&(String)teamselect!=null)&&CK.ActiveGame.State!=GameState.Running){
                TeamSelect(teamselect);
            }
            //change team name
            var teamindex = Request.Form["teamindex"];
            if(teamindex != "" && (String)teamindex != null&&CK.ActiveGame.State!=GameState.Running){
                var teamname = Request.Form["teamname"];
                if(teamname != "" && (String)teamname != null){
                    CK.ActiveGame.Gamemode.Teams[Convert.ToInt16(teamindex)].Name=teamname;
                }
            }
            //gamemode select
            var modeselect = Request.Form["modeselect"];
            if(modeselect != "" && (String)modeselect != null&&CK.ActiveGame.State!=GameState.Running){
                CK.ActiveGame.SelectGameMode(Convert.ToInt16(modeselect));
            }

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

            if((String)gamestart!=null){
                CK.ActiveGame.StartGame(CK.wifiHandler);

            }else if((String)gamestop!=null){
                CK.ActiveGame.EndGame(CK.wifiHandler);
            }

 
            

            return Page();
        }
        public void TeamSelect(string teamSelect)
        {
            string[] ts = teamSelect.Split(' ');
            
            int pId = Convert.ToInt16(ts[0]);
            
            byte[] compareArr = new byte[2];
            Buffer.BlockCopy(BitConverter.GetBytes(pId), 0, compareArr, 0, 2);
            Player p = CK.wifiHandler.Clients.Find(x=>x.Client.ConState==ConnectionState.GameReady&&x.Client.LWInv.Items.Find(x=>x.Id==0x14).Value.SequenceEqual(compareArr));
            if(p!=null)CK.ActiveGame.ChangeTeam(p, Convert.ToInt16(ts[1]));
            
        }
        private static string FormatBytes(Byte[] bytes)
        {
            string value = "";
            foreach (var byt in bytes)
                value += String.Format("{0:X2} ", byt);

            return value;
        }
    }
}
