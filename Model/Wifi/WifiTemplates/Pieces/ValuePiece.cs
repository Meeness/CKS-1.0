using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class ValuePiece:Piece{
        public ValuePiece(int direction, byte[] value):base(direction, value){}
        public ValuePiece(DateTime timestamp):base(timestamp){}
    }
}