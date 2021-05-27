using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class ApplicationBroadcast:Message{
        public ApplicationBroadcast(DateTime timestamp):base(0x01, 0x00)
        {
            Blocks.Add(new TimeStampBlock(timestamp));
        }
    }
}