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
        //get ranges
        //implement function calls->06->start&end, 05 0a.
        //bind settings
        //bind game time
        //endianess -> when it leaves and enters the system

        //test
        private static CombatKarts _instance;
        public static CombatKarts Instance{
            get{
                if(_instance==null)_instance=new CombatKarts();
                return _instance;
                }
        }
        public Game ActiveGame{get;set;}

        private List<Gamemode> Gamemodes{get;set;}//list of gamemodes

        public List<Player> PlayerList{get;set;}
        
        public WifiHandler wifiHandler{get;set;}

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


            ActiveGame=new Game(Gamemodes);

            PlayerList=new List<Player>();
            wifiHandler=new WifiHandler();

            Thread t2 = new Thread(()=>UpdateCycle());
            t2.Start();

            //test
            CreatePlayerTest();
            
        }
        public void UpdateCycle(){
            while(true)
            {   
                foreach(Player p in wifiHandler.Clients){
                    if(p.Client.ConState==ConnectionState.Initialized||p.Client.ConState==ConnectionState.Online){
                        if(ActiveGame.AvailPlayers.Find(x=>x.Id==p.Id)==null&&p.Client.ConState==ConnectionState.Online)ActiveGame.AvailPlayers.Add(p);
                        wifiHandler.SendMessage(new InventoryUpdateMessage(p.Client.Msgcount, p.Client.LWInv), p.Client);
                        Thread.Sleep(200);
                    }
                }
                Thread.Sleep(200);
            }      
        }
        private void CreatePlayerTest(){//testfunction
            

            
            //LWI.Items.Add(new IntItem(15, 1));
            Client c = new Client(new IPAddress(new byte[]{0x00,0x00,0x00,0x01}), WifiHandler.Port);
            c.CKInv.Items.Add(new Item(1, "PlayerOne"));


            Player p = new Player(c);
            ActiveGame.AvailPlayers.Add(p);
            PlayerList.Add(p);
            
        }
    }
}
