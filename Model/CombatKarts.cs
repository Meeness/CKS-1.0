using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        private List<Gamemode> Gamemodes{get;set;}

        public List<Player> PlayerList{get;set;}
        

        private CombatKarts()
        {

            Gamemodes=new List<Gamemode>();
            Gamemodes.Add(new Gamemode(1, "Team Mode", "Fight together in a team against the other team."));
            Gamemodes[0].Teams.Add(new Team(1, "Team One"));
            Gamemodes[0].Teams.Add(new Team(2, "Team Two"));
            Gamemodes.Add(new Gamemode(2, "One For All", "Everyone for themself"));
            Gamemodes[1].Teams.Add(new Team(1, "One For All"));


            ActiveGame=new Game(Gamemodes);

            PlayerList=new List<Player>();

            //test
            CreatePlayerTest();
            
        }
        private void CreatePlayerTest(){//testfunction
            
            Inventory LWI = new Inventory();
            Inventory CKI = new Inventory();
            CKI.Items.Add(new StringItem(1, "PlayerOne"));
            Client c = new Client();
            

            c.CKInv=CKI;
            c.LWInv=LWI;
            Player p = new Player(c);
            ActiveGame.AvailPlayers.Add(p);
            
        }
    }
}
