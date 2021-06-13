using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using CKS_1._0.Model;
using CKS_1._0.Model.Wifi.WifiTemplates;

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
        public IActionResult OnPost(){
            List<byte[]> LWbytelist = new List<byte[]>{};
            List<byte[]> CKbytelist = new List<byte[]>{};

            var hiddenplayerid = Request.Form["hiddenplayerid"];
            LWbytelist.Add(new byte[2]);
            byte[] hiddenplayeridb = BitConverter.GetBytes(Convert.ToInt32(hiddenplayerid));
            Buffer.BlockCopy(hiddenplayeridb, 0, LWbytelist[0], 0, 2);
            
            Player p = CK.wifiHandler.Clients.Find(x=>x.Client.ConState==ConnectionState.GameReady&&x.Client.LWInv.Items.Find(y=>y.Id==0x14).Value.SequenceEqual(LWbytelist[0]));
 
            Inventory LWinv = new Inventory();

            var playerid = Request.Form["playerid"]; 
            LWbytelist.Add(new byte[2]);
            byte[] playeridb = BitConverter.GetBytes(Convert.ToInt32(playerid));
            Buffer.BlockCopy(playeridb, 0, LWbytelist[1], 0, 2);
            if(!p.Client.LWInv.Items.Find(x=>x.Id==0x14).Value.SequenceEqual(LWbytelist[1])) LWinv.Items.Add(new Item(0x14, LWbytelist[1]));

            var health = Request.Form["health"]; 
            LWbytelist.Add(new byte[2]);
            byte[] healthb = BitConverter.GetBytes(Convert.ToInt32(health));
            Buffer.BlockCopy(healthb, 0, LWbytelist[2], 0, 2);
            if(!p.Client.LWInv.Items.Find(x=>x.Id==0x16).Value.SequenceEqual(LWbytelist[2])) LWinv.Items.Add(new Item(0x16, LWbytelist[2]));

            var friendlyfire = Request.Form["friendlyfire"]; 
            LWbytelist.Add(new byte[1]);
            byte[] friendlyfireb = BitConverter.GetBytes(Convert.ToInt32(friendlyfire));
            Buffer.BlockCopy(friendlyfireb, 0, LWbytelist[3], 0, 1);
            if(!p.Client.LWInv.Items.Find(x=>x.Id==0x17).Value.SequenceEqual(LWbytelist[3]))LWinv.Items.Add(new Item(0x17, LWbytelist[3]));


            /****************** CK ****************/ 
            var shieldduration = Request.Form["shieldduration"]; //CK
            CKbytelist.Add(new byte[1]);
            byte[] shielddurationb = BitConverter.GetBytes(Convert.ToInt32(shieldduration));
            Buffer.BlockCopy(shielddurationb, 0, CKbytelist[0], 0, 1);
            

            var shieldcooldown = Request.Form["shieldcooldown"];  //CK
            CKbytelist.Add(new byte[1]);
            byte[] shieldcooldownb = BitConverter.GetBytes(Convert.ToInt32(shieldcooldown));
            Buffer.BlockCopy(shieldcooldownb, 0, CKbytelist[1], 0, 1);
            /***************************************/
            
            var clips = Request.Form["clips"]; 
            LWbytelist.Add(new byte[1]);
            byte[] clipsb = BitConverter.GetBytes(Convert.ToInt32(clips));
            Buffer.BlockCopy(clipsb, 0, LWbytelist[4], 0, 1);
            if(!p.Client.LWInv.Items.Find(x=>x.Id==0x34).Value.SequenceEqual(LWbytelist[4])) LWinv.Items.Add(new Item(0x34, LWbytelist[4]));

            var bullets = Request.Form["bullets"]; 
            LWbytelist.Add(new byte[2]);
            byte[] bulletsb = BitConverter.GetBytes(Convert.ToInt32(bullets));
            Buffer.BlockCopy(bulletsb, 0, LWbytelist[5], 0, 2);
            if(!p.Client.LWInv.Items.Find(x=>x.Id==0x35).Value.SequenceEqual(LWbytelist[5])) LWinv.Items.Add(new Item(0x35, LWbytelist[5]));

            var damage = Request.Form["damage"]; 
            LWbytelist.Add(new byte[2]);
            byte[] damageb = BitConverter.GetBytes(Convert.ToInt32(damage));
            Buffer.BlockCopy(damageb, 0, LWbytelist[6], 0, 2);
            if(!p.Client.LWInv.Items.Find(x=>x.Id==0x38).Value.SequenceEqual(LWbytelist[6])) LWinv.Items.Add(new Item(0x38, LWbytelist[6]));

            var reloadduration = Request.Form["reloadduration"]; 
            LWbytelist.Add(new byte[1]);
            byte[] reloaddurationb = BitConverter.GetBytes(Convert.ToInt32(reloadduration));
            Buffer.BlockCopy(reloaddurationb, 0, LWbytelist[7], 0, 1);
            if(!p.Client.LWInv.Items.Find(x=>x.Id==0x39).Value.SequenceEqual(LWbytelist[7])) LWinv.Items.Add(new Item(0x39, LWbytelist[7]));

            var autoreload = Request.Form["autoreload"];
            LWbytelist.Add(new byte[1]);
            byte[] autoreloadb = BitConverter.GetBytes(Convert.ToInt32(autoreload));
            Buffer.BlockCopy(autoreloadb, 0, LWbytelist[8], 0, 1);
            if(!p.Client.LWInv.Items.Find(x=>x.Id==0x3a).Value.SequenceEqual(LWbytelist[8])) LWinv.Items.Add(new Item(0x3a, LWbytelist[8]));

            if(LWinv.Items.Count>0&&!CK.testing){
                CK.wifiHandler.SendMessage(new InventoryChangeMessage(p.Client.Msgcount, LWinv), p.Client);
            }
            Thread.Sleep(3000);
            return Page();
        }
    }
}
