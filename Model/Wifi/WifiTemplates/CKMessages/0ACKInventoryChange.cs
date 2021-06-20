using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class CKInventoryChange:Message{
        public CKInventoryChange(Inventory inv):base(0x0a, 0x00, false)
        {
            foreach(Item item in inv.Items){
                Blocks.Add(new CKItemBlock0A(item));
            }
        }
    }
}