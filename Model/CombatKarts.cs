using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CKS_1._0.Model.Wifi;
using CKS_1._0.Model.Wifi.WifiTemplates;
using System.Net;
using System.Threading;


namespace CKS_1._0.Model
{
    public class CombatKarts
    {
        private static CombatKarts _instance;
        public static CombatKarts Instance{
            get{
                if(_instance==null)_instance=new CombatKarts();
                return _instance;
                }
        }
        public Game ActiveGame{get;set;}
        private List<Gamemode> Gamemodes{get;set;}//list of gamemodes
        public WifiHandler wifiHandler{get;set;}

        //test
        public bool testing = false;

        private CombatKarts()
        {

            Gamemodes=new List<Gamemode>(); 
            //creating Team Mode gamemode
            Gamemodes.Add(new Gamemode(1, "Team Mode", "Fight together in a team against the other team."));
            Gamemodes[0].Teams.Add(new Team(1, "Team One"));
            Gamemodes[0].Teams.Add(new Team(2, "Team Two"));
            Gamemodes[0].Settings.Items.Add(new Item(0x3A, new byte[]{0x01})); //autoreload on
            //creating One For All gamemode
            Gamemodes.Add(new Gamemode(2, "One For All", "Everyone for themself"));
            Gamemodes[1].Teams.Add(new Team(1, "One For All"));
            Gamemodes[1].Settings.Items.Add(new Item(0x17, new byte[]{0x01})); //friendlyfire on
            Gamemodes[1].Settings.Items.Add(new Item(0x3A, new byte[]{0x01})); //autoreload on


            

            //PlayerList=new List<Player>();
            wifiHandler=new WifiHandler();
            ActiveGame=new Game(Gamemodes, wifiHandler.Clients);

            Thread t2 = new Thread(()=>UpdateCycle());
            t2.Start();

            //test
            //CreatePlayerTest();
            //CreatePlayerTest();
            
        }
        public void NewGame(){
            ActiveGame.ClearTeams();
            ActiveGame=new Game(Gamemodes, wifiHandler.Clients);
        }
        public void UpdateCycle(){
            while(!testing)
            {   
                foreach(Player p in wifiHandler.Clients){
                    if(p.Client.ConState==ConnectionState.Online&&p.Client.CKConState==CKConnectionState.Online){
                        p.Client.ConState=ConnectionState.GameReady;
                        ActiveGame.AvailPlayers.Add(p);
                    }
                    if(ActiveGame.State==GameState.Running){
                        wifiHandler.SendMessage(new QueuedDataMessage(p.Client.Msgcount, wifiHandler.EventTimeStamp), p.Client);
                        wifiHandler.CKSendMessage(new CKEventUpdate(wifiHandler.CKEventNdx), p.Client);
                        if(ActiveGame.IsGameOver())ActiveGame.EndGame(wifiHandler);
                    }
                    if(p.Client.ConState==ConnectionState.Initialized||p.Client.ConState==ConnectionState.GameReady){

                        wifiHandler.SendMessage(new InventoryUpdateMessage(p.Client.Msgcount, p.Client.LWInv), p.Client);
                        
                    }
                    if(p.Client.CKConState==CKConnectionState.Authenticated||p.Client.CKConState==CKConnectionState.Online){
                        wifiHandler.CKSendMessage(new CKInventoryUpdate(), p.Client);
                    }
                    Thread.Sleep(200);
                }
                Thread.Sleep(200);
            }      
        }
        public byte[] ConvertTo4Byte(byte[] bytes){
            byte[] returnArr = new byte[4];
            for(int i = 0;i<4;i++){
                if(bytes.Length>i)returnArr[i]=bytes[i];
                else returnArr[i]=0x00;
            }
            return returnArr;
        }
        public void CreatePlayerTest(){//testfunction
            testing = true;
            byte b = 0x01;
            foreach(Player pl in wifiHandler.Clients)b++;
            
            Client c = new Client(new IPAddress(new byte[]{ 0xc0, 0xa8, 0x00, b}), WifiHandler.Port);
            c.CKendPoint = new IPEndPoint(new IPAddress(new byte[]{0xc0, 0xa8, 0x01, b}), WifiHandler.Port);
            c.ConState = ConnectionState.GameReady;
            
            
            

            c.LWInv.Items.Add(new Item(0x14, new byte[]{b, 0x00}, 1));//Playerid
            c.LWInv.Items.Add(new Item(0x15, new byte[]{0x03}, 0));//TeamColor
            c.LWInv.Items.Add(new Item(0x16, new byte[]{0xe7, 0x03}, 1));//Hp
            c.LWInv.Items.Add(new Item(0x17, new byte[]{0x01}, 0));//Friendly fire  *****
            c.LWInv.Items.Add(new Item(0x34, new byte[]{0xff}, 0));//Clips
            c.LWInv.Items.Add(new Item(0x35, new byte[]{0x0e, 0x27}, 1));//Bullets  *****
            c.LWInv.Items.Add(new Item(0x38, new byte[]{0x64, 0x00}, 1));//Damage
            c.LWInv.Items.Add(new Item(0x39, new byte[]{0xff}, 0));//ReloadDuration *****
            c.LWInv.Items.Add(new Item(0x3a, new byte[]{0x01}, 0));//AutoReload


            //current values
            c.LWInv.Items.Add(new Item(0x22, new byte[]{0xe7, 0x03}, 1));//CurrentHp
            c.LWInv.Items.Add(new Item(0x4f, new byte[]{0xff}, 0));//CurrentClips
            c.LWInv.Items.Add(new Item(0x50, new byte[]{0x0e, 0x27}, 1));//CurrentBullets



            c.LWInvAll.Items.Add(new Item(0x14));//Playerid
            c.LWInvAll.Items.Add(new Item(0x15));//TeamColor
            c.LWInvAll.Items.Add(new Item(0x16));//Hp
            c.LWInvAll.Items.Add(new Item(0x17));//Friendly fire 
            c.LWInvAll.Items.Add(new Item(0x34));//Clips
            c.LWInvAll.Items.Add(new Item(0x35));//Bullets
            c.LWInvAll.Items.Add(new Item(0x38));//Damage
            c.LWInvAll.Items.Add(new Item(0x39));//ReloadDuration
            c.LWInvAll.Items.Add(new Item(0x3a));//AutoReload


            //current values
            c.LWInvAll.Items.Add(new Item(0x22));//CurrentHp
            c.LWInvAll.Items.Add(new Item(0x4f));//CurrentClips
            c.LWInvAll.Items.Add(new Item(0x50));//CurrentBullets

            Player p = new Player(c);
            ActiveGame.AvailPlayers.Add(p);
            wifiHandler.Clients.Add(p);
            //PlayerList.Add(p);//eh no no no
            
        }
    }
}
