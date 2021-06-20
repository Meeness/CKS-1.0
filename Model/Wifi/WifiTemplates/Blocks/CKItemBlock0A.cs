using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class CKItemBlock0A:Block{
        public CKItemBlock0A(Item item):base(
            new List<Piece> {
                new IdentifierPiece(item.Id),
                new ValueLengthPiece(Convert.ToByte(item.Value.Length)),
                new ValuePiece(item.Value)
            }
        ){}
    }
}