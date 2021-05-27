using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Threading;

namespace CKS_1._0.Model.Wifi
{
    public class WifiHandler{

        public const int Port = 53443;
        public IPAddress Router = new IPAddress(new byte[] { 0xff, 0xff, 0xff, 0xff });

        public List<Player> Clients {get;set;}
        public string teststring {get;set;}

        //public IPAddress Gun = new IPAddress(new byte[] { 0xc0, 0xa8, 0x1f, 0xf5 });

        public WifiHandler()
        {
            teststring = "NUTTINGAH!?";
            teststring +="LOL?";
            //Thread t1 = new Thread(()=>BroadcastListener());
            //t1.Start();
            
        }
        public void SendMessage(Message msg, Client client){
            
        }
        public void WifiReader(){
            //teststring += "Thread: "+Thread.CurrentThread.ManagedThreadId+";";
            while(false){
                //listen
            }
        }
        public void BroadcastListener(){
            bool ReaderStartet = false;
            teststring += "BUTISURELNUTING?!";
            while(!ReaderStartet){
                
                if(!ReaderStartet){//client found
                    if(!ReaderStartet)//client not in clientlist
                    {
                        //teststring += "Thread: "+Thread.CurrentThread.ManagedThreadId+";";
                        IPAddress ip = new IPAddress(new byte[]{0x00,0x00,0x00,0x00});//ip from client
                        Client c = new Client(ip, Port);
                        Clients.Add(new Player(c));
                        if(!ReaderStartet){
                            //start wifireader
                            //Thread t2 = new Thread(()=>WifiReader());
                            //t2.Start();
                            ReaderStartet=true;
                        }
                    }
                }
                
            }
        }
    }
}