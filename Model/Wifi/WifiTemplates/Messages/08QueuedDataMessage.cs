using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class QueuedDataMessage:Message{
        public QueuedDataMessage(byte msgcount, DateTime timestamp):base(0x08, msgcount)
        {
            Blocks.Add(new TimeStampBlock(timestamp));
        }
    }
}