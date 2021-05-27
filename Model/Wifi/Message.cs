using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CKS_1._0.Model.Wifi.WifiTemplates;

namespace CKS_1._0.Model.Wifi
{
    public class Message{
        
        public List<Block> Blocks {get;set;}

        public Message(byte classification, byte msgcount )
        {
            Blocks = new List<Block>();
            Blocks.Add(new WaterMark());
            Blocks.Add(new IdentifierBlock(classification, msgcount));
        }

    }
}