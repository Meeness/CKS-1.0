using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;
using System.Text;
using CKS_1._0.Model.Wifi.WifiTemplates;

namespace CKS_1._0.Model.Wifi
{
    public class WifiHandler{

        public const int Port = 53443;
        public IPAddress Router = new IPAddress(new byte[] { 0xff, 0xff, 0xff, 0xff });

        public List<Player> Clients {get;set;}
        public string teststring {get;set;}
        public Inventory LWItemsUsed {get;set;}
        public Inventory CKItemsUsed {get;set;}

        
        //public IPAddress Gun = new IPAddress(new byte[] { 0xc0, 0xa8, 0x1f, 0xf5 });

        public WifiHandler()
        {
            Clients=new List<Player>();
            LWItemsUsed = new Inventory();

            LWItemsUsed.Items.Add(new Item(0x14, 0, new byte[]{0x01, 0x00}, new byte[]{0x7e, 0x00}));//Playerid

            LWItemsUsed.Items.Add(new Item(0x15, 0, new byte[]{0x00}, new byte[]{0x03}));//TeamColor
            LWItemsUsed.Items.Add(new Item(0x16, 1, new byte[]{0x01, 0x00}, new byte[]{0xe7, 0x03}));//Hp
            LWItemsUsed.Items.Add(new Item(0x17, 0, new List<byte[]>{new byte[]{0x00}, new byte[]{0x01}}));//Friendly fire
            
            LWItemsUsed.Items.Add(new Item(0x34, 0, new byte[]{0x00}, new byte[]{0xff}));//Clips
            LWItemsUsed.Items.Add(new Item(0x35, 1, new byte[]{0x00, 0x00}, new byte[]{0x0e, 0x27}));//Bullets
            LWItemsUsed.Items.Add(new Item(0x38, 0, new List<byte[]>{
                new byte[]{0x01, 0x00}, 
                new byte[]{0x02, 0x00}, 
                new byte[]{0x04, 0x00}, 
                new byte[]{0x05, 0x00}, 
                new byte[]{0x07, 0x00}, 
                new byte[]{0x0a, 0x00}, 
                new byte[]{0x0f, 0x00},
                new byte[]{0x11, 0x00},
                new byte[]{0x14, 0x00},
                new byte[]{0x19, 0x00},
                new byte[]{0x1e, 0x00},
                new byte[]{0x23, 0x00},
                new byte[]{0x28, 0x00},
                new byte[]{0x32, 0x00},
                new byte[]{0x4b, 0x00},
                new byte[]{0x64, 0x00},
                }));//Damage
            LWItemsUsed.Items.Add(new Item(0x39, 0, new byte[]{0x01}, new byte[]{0xff}));//ReloadDuration
            LWItemsUsed.Items.Add(new Item(0x3a, 0, new List<byte[]>{new byte[]{0x00}, new byte[]{0x01}}));//AutoReload

            //current values
            LWItemsUsed.Items.Add(new Item(0x22));//CurrentHp

            LWItemsUsed.Items.Add(new Item(0x4f));//CurrentClips
            LWItemsUsed.Items.Add(new Item(0x50));//CurrentBullets

            CKItemsUsed = new Inventory();

            CKItemsUsed.Items.Add(new Item(0x01));//playername
            CKItemsUsed.Items.Add(new Item(0x02, 0, new byte[]{0x00}, new byte[]{0xff}));//shield duration
            CKItemsUsed.Items.Add(new Item(0x03, 0, new byte[]{0x00}, new byte[]{0xff}));//shield cooldown

            teststring = "NUTTINGAH!?";
            teststring +="LOL?";
            teststring += "Thread: "+Thread.CurrentThread.ManagedThreadId+";";

            Thread t1 = new Thread(()=>WifiReader());
            t1.Start();
            
            
        }
        public void SendMessage(Message msg, Client client){
            byte[] m = msg.CombinedMessage();
            client.Socket.Send(m, m.Length, client.endPoint);    
        }
        public void WifiReader(){
            teststring += "BUTISURELNUTING?!";
            teststring += "Thread: "+Thread.CurrentThread.ManagedThreadId+";";
            using (UdpClient socket = new UdpClient(new IPEndPoint(IPAddress.Any, Port)))
            {
                IPEndPoint remoteEndPoint = new IPEndPoint(0, 0);
                while(true){
                    byte[] datagramReceived = socket.Receive(ref remoteEndPoint);                    
                    if(datagramReceived.Length>=8&&Encoding.ASCII.GetString(datagramReceived, 0, 4)=="<LW>")
                    {
                        
                        switch (datagramReceived[4])
                        {
                            case 0x02:
                                if(Clients.Find(x=>x.Client.endPoint.Address.ToString()==remoteEndPoint.Address.ToString())==null)//client !exist
                                {                                    
                                    Player p = new Player(new Client(remoteEndPoint.Address, Port));
                                    Clients.Add(p);
                                    SendMessage(new AuthenticateMessage(DateTime.Now), p.Client);
                                }
                                break;
                            case 0x03:
                                Player p3 = Clients.Find(x=>x.Client.endPoint.Address.ToString()==remoteEndPoint.Address.ToString());
                                if(p3!=null)//client exist
                                {
                                    p3.Client.ConState = ConnectionState.Authenticated;
                                    SendMessage(new InventoryInitMessage(p3.Client.Msgcount), p3.Client);
                                }
                                break;
                            case 0x04:
                                Player p4 = Clients.Find(x=>x.Client.endPoint.Address.ToString()==remoteEndPoint.Address.ToString());
                                if(p4!=null)//client exist
                                {
                                    if(datagramReceived.Length%8==0){
                                        for(int i = 12;i<datagramReceived.Length;i+=8){
                                            Item item = new Item(datagramReceived[i]);
                                            p4.Client.LWInvAll.Items.Add(item);
                                            if(LWItemsUsed.Items.Find(x=>x.Id==item.Id)!=null)p4.Client.LWInv.Items.Add(item);         
                                        }
                                        p4.Client.ConState = ConnectionState.Initialized;
                                    }   
                                }
                                break;
                            case 0x05:
                                //something
                                break;
                            case 0x06:
                                //something
                                break;
                            case 0x08:
                                //read
                                //something
                                break;
                            case 0x09:
                                Player p9 = Clients.Find(x=>x.Client.endPoint.Address.ToString()==remoteEndPoint.Address.ToString());
                                if(p9!=null)//client exist
                                {
                                    int nextValuelen;
                                    int nextIdNdx = 8;
                                    for(int i = 8;i<datagramReceived.Length;i++){
                                        if(nextIdNdx == i){
                                            nextValuelen=datagramReceived[i+3];
                                            nextIdNdx=i+4+nextValuelen;
                                            Item item = p9.Client.LWInv.Items.Find(x=>x.Id==datagramReceived[i]);
                                            Buffer.BlockCopy(item.ReadDirection==ReadingDirection.Forwards?datagramReceived:Item.ReverseBytes(datagramReceived), i+4, item.Value, 0, nextValuelen);
                                        } 
                                    }
                                    if(p9.Client.ConState==ConnectionState.Initialized)p9.Client.ConState=ConnectionState.Online;
                                }
                                //something
                                break;
                            case 0x0a:
                                //something
                                break;
                            default:
                                //something
                                break;
                        }
                    }    
                }
            }
        }
        public void BroadcastListener(){
            bool ReaderStartet = false;
            teststring += "BUTISURELNUTING?!";
            teststring += "Thread: "+Thread.CurrentThread.ManagedThreadId+";";
            
            using (UdpClient socket = new UdpClient(new IPEndPoint(IPAddress.Any, Port)))
            {
                IPEndPoint remoteEndPoint = new IPEndPoint(0, 0);
                while(true){
                    byte[] datagramReceived = socket.Receive(ref remoteEndPoint);
                    string message = Encoding.ASCII.GetString(datagramReceived, 0, datagramReceived.Length);
                    teststring += "dingdong!";
                    teststring += message;
                    if(!ReaderStartet){//client found
                        if(!ReaderStartet)//client not in clientlist
                        {
                            
                            //IPAddress ip = new IPAddress(new byte[]{0x00,0x00,0x00,0xff});//ip from client
                            //Client c = new Client(new IPAddress(new byte[]{0x00,0x00,0x00,0xff}), Port);
                            
                            if(!ReaderStartet){
                                //start wifireader
                                Thread t2 = new Thread(()=>WifiReader());
                                t2.Start();
                                ReaderStartet=true;
                            }
                        }
                    }
                    
                }
            }
        }
    }
}