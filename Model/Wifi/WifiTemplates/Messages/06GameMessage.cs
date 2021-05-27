using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class GameMessage:Message
    {
        public GameMessage(byte msgcount, bool gameStart, DateTime timestamp = new DateTime(), UInt32 gameDuration = 0 ):base(0x06, msgcount)
        {
            if(gameStart){
                Blocks.Add(new TimeStampBlock(timestamp));
                Blocks.Add(new ItemBlock06(gameDuration));
            }else{
                Blocks.Add(new EndBlock(12));
            }
        }
    }
}