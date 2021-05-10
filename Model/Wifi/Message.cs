using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi
{
    public class Message{
        
        public List<Block> Blocks {get;set;}

        public Message()
        {
            Blocks = new List<Block>();
        }

    }
}