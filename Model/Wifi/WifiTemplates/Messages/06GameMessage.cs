using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class GameMessage:Message
    {
        public GameMessage(int msgcount)
        {
            Blocks.Add(new WaterMark());
            Blocks.Add(new IdentifierBlock(6, msgcount));
            //make message etc. abstract
            //problem when reading with value having diffrent data types
            //make 01 -> 01 00 00 00
        }
    }
}