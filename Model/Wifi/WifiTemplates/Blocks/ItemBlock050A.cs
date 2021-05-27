using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class ItemBlock050A:Block{
        public ItemBlock050A(Item item):base(
            new List<Piece>{
                new IdentifierPiece(item.Id),
                new SeparatorPiece(),
                new ValueLengthPiece(Convert.ToByte(item.Value.Length)),
                new ValuePiece(item.Value, item.ReadDirection)
            }
        ){}
    }
}