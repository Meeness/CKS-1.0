using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class WaterMark:Block{
        public WaterMark():base(new Piece(0, new byte[]{0x3c, 0x4c, 0x57, 0x3e}))
        {
            
        }
    }
}