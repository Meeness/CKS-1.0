using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class WaterMark:Block{
        public WaterMark(string waterMark):base(new ValuePiece(waterMark)){}
    }
}