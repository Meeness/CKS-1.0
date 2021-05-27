using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class EndBlock:Block{
        public EndBlock(int amount):base(new List<Piece>{})
        {
            for(int i=0;i<amount;i++){
                Pieces.Add(new SeparatorPiece());
            }
        }
    }
}