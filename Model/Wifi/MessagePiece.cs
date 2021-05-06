using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi
{
    public class MessagePiece{
        public byte[] Piece {get;set;}
        public ReadingDirection ReadDirection {get;set;}
    }
    public enum ReadingDirection{
        Forwards,
        Backwards
    }
}