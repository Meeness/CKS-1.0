using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CKS_1._0.Model.Wifi;

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
            //test
            CreatePlayerTest();
            
        }
        private void CreatePlayerTest(){//testfunction
            
            Inventory LWI = new Inventory();
            Inventory CKI = new Inventory();
            CKI.Items.Add(new Item(1, "PlayerOne"));
            //LWI.Items.Add(new IntItem(15, 1));
            Client c = new Client(new System.Net.IPAddress(new byte[]{0x00,0x00,0x00,0x00}), WifiHandler.Port);
            

            c.CKInv=CKI;
            c.LWInv=LWI;
            Player p = new Player(c);
            ActiveGame.AvailPlayers.Add(p);
            PlayerList.Add(p);
            
        }
    }
}
