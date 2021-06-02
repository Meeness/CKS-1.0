using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class IdentifierBlock:Block{
        public IdentifierBlock(byte classification, byte msgcount):base(
            new List<Piece>{
                new ClassificationPiece(classification),
                new SeparatorPiece(),
                new MessageCountPiece(msgcount),
                new TypePiece()
            }
        ){}
    }
}