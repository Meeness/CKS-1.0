using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class GamemodeItemUpdateMessage:Message{
        public GamemodeItemUpdateMessage(byte msgcount, Inventory inv):base(0x05, msgcount)
        {
            foreach(Item item in inv.Items){
                Blocks.Add(new ItemBlock050A(item));
            }
        }
    }
}