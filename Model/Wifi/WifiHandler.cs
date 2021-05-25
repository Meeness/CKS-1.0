using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi
{
    public class WifiHandler{

        public const int Port = 53443;
        public IPAddress Router = new IPAddress(new byte[] { 0xff, 0xff, 0xff, 0xff });

        public List<Player> Clients {get;set;}

        //public IPAddress Gun = new IPAddress(new byte[] { 0xc0, 0xa8, 0x1f, 0xf5 });

        public WifiHandler()
        {
            
        }
        public void SendMessage(){

        }
        public void WifiReader(){
            
        }
    }
}