using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class ApplicationBroadcast:Message{
        public ApplicationBroadcast(int msgcount, DateTime timestamp)
        {
            Blocks.Add(new WaterMark());
            Blocks.Add(new IdentifierBlock(1, msgcount));
            Blocks.Add(new TimeStampBlock(timestamp));
        }
    }
}