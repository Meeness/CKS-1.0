using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class CKEventUpdate:Message{
        public CKEventUpdate(UInt16 eventid):base(0x08, 0x00, false)
        {
            Blocks.Add(new CKEventBlock(eventid));
        }
    }
}