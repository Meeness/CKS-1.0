using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class ItemBlock06:Block{
        public ItemBlock06(UInt32 gameDuration):base(
            new List<Piece>{
                new ValuePiece(gameDuration)
            }
        ){}
    }
}