using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class CKConnectionLock:Message{
        public CKConnectionLock():base(0x03, 0x00, false){}
    }
}