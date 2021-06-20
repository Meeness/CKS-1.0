using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class CKGame:Message{
        public CKGame(bool gameStart):base(0x06, 0x00, false)
        {   
            if(gameStart)Blocks.Add(new CKGameBlock(0x01));
            else Blocks.Add(new CKGameBlock(0x00));
        }
    }
}