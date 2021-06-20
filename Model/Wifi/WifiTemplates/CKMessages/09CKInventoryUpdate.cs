using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class CKInventoryUpdate:Message{
        public CKInventoryUpdate():base(0x09, 0x00, false){}
    }
}