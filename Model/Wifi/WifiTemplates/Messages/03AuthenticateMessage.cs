using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class AuthenticateMessage:Message{
        public AuthenticateMessage(DateTime dateTime):base(0x03, 0x00)
        {
            Blocks.Add(new ItemBlock03(0x01));
            Blocks.Add(new TimeStampBlock(dateTime));
            Blocks.Add(new Unknown03Block());
        }
    }
}