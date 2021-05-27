using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class TimeStampBlock:Block{
        public TimeStampBlock(DateTime timestamp):base(new ValuePiece(timestamp)){}
    }
}