using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class ItemBlock03:ItemBlock{
        public ItemBlock03(byte ItemId):base(
            new List<Piece>{
                new SeparatorPiece(),
                new IdentifierPiece(ItemId),
                new SeparatorPiece(),
                new SeparatorPiece()
            }
        ){}
    }
}