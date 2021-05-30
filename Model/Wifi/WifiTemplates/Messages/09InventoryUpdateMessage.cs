using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class InventoryUpdateMessage:Message
    {
        public InventoryUpdateMessage(byte msgcount, Inventory inv):base(0x09, msgcount)
        {
            foreach(Item item in inv.Items){
                Blocks.Add(new ItemBlock09(item.Id));
            }
        }
    }
}