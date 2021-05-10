using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi
{
    public class Block{
        public ReadingDirection ReadDirection {get;set;}
        public List<Piece> Pieces {get;set;}
    }
    public enum ReadingDirection{
        Forwards,
        Backwards
    }
}