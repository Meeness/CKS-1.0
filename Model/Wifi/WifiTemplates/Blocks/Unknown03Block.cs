using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class Unknown03Block:Block{
        public Unknown03Block():base(
            new ValuePiece(new byte[]{0xD7, 0xC6, 0xD6, 0x70, 0x0B, 0xC3, 0x3C, 0x4E, 0xAA, 0x8E, 0xE6, 0xD9, 0x94, 0x6A, 51, 0x23}, 1)
        ){}
    }
}