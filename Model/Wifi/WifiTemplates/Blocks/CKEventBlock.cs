using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class CKEventBlock:Block{
        public CKEventBlock(UInt16 id):base(new ValuePiece(id)){}
    }
}