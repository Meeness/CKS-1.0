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
    public class GameSettingsModel : PageModel
    {
        private readonly ILogger<GameSettingsModel> _logger;
        public CombatKarts CK = CombatKarts.Instance;
        public string test = "testy";


        public GameSettingsModel(ILogger<GameSettingsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
        }
        public IActionResult OnPost(){
            //teamselect
            var teamselect = Request.Form["teamselect"];
            foreach(String ts in teamselect){
                if(ts.Length>0) TeamSelect(ts);
            }
            //change team name
            var teamindex = Request.Form["teamindex"];
            if(teamindex != "" && (String)teamindex != null){
                var teamname = Request.Form["teamname"];
                if(teamname != "" && (String)teamname != null){
                    CK.ActiveGame.Gamemode.Teams[Convert.ToInt16(teamindex)].Name=teamname;
                }
            }
            //gamemode select
            var modeselect = Request.Form["modeselect"];
            if(modeselect != "" && (String)modeselect != null){
                CK.ActiveGame.SelectGameMode(Convert.ToInt16(modeselect));
            }
            

            return Page();
        }
        public void TeamSelect(string teamSelect)
        {
            string[] ts = teamSelect.Split(' ');
            
            int pId = Convert.ToInt16(ts[0]);
            
            byte[] compareArr = new byte[2];
            Buffer.BlockCopy(BitConverter.GetBytes(pId), 0, compareArr, 0, 2);
            test="here it is: "+ts[0]+"-"+FormatBytes(CK.PlayerList[0].Client.LWInv.Items[0].Value)+"-"+FormatBytes(compareArr)+"!!!";
            Player p = CK.PlayerList.Find(x=>x.Client.LWInv.Items.Find(x=>x.Id==0x14).Value.SequenceEqual(compareArr));
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
