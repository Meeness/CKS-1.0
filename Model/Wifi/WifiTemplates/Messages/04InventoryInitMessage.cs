using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class InventoryInitMessage:Message{
        public InventoryInitMessage(byte msgcount):base(0x04, msgcount)
        {
            Blocks.Add(new EndBlock(2));
        }
    }
}