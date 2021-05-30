using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class ItemBlock09:ItemBlock{
        /*public ItemBlock09(int id, int direction, byte[] value):base(  //reading
            new List<Piece>{
                new IdentifierPiece(id),
                new SeparatorPiece(),
                new SeparatorPiece(),
                new ValueLengthPiece(value.Length),
                new ValuePiece(direction, value)
            }
        ){}*/
        public ItemBlock09(byte id):base( //writing
            new List<Piece>{
                new IdentifierPiece(id),
                new SeparatorPiece()
            }
        ){}
    }
}