using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CKS_1._0.Model
{
    public class Game
    {
        public int Id{get;set;}
        public GameState GameState {get;set;}
        public Gamemode Gamemode {get;set;}
        public List<Gamemode> GamemodeList {get;set;}

        public DateTime GameStart{get;set;}
        public int GameDuration{get;set;}
        public int GameDelay{get;set;}

        public List<Player> AvailPlayers{get;set;}

        public Game(List<Gamemode> gamemodes)
        {
            GamemodeList = gamemodes;
            AvailPlayers = new List<Player>();
           
            GameDuration=15;
            GameDelay=5;
            SelectGameMode(1);
        }
        public void SelectGameMode(int id){
            Gamemode G =GamemodeList.Find(x=>x.Id==id);
            if(G!=null)Gamemode=G;
        }
        public void ChangeTeam(Player player, int FromTeamId, int ToTeamId){
            if(FromTeamId<=Gamemode.Teams.Count||ToTeamId<=Gamemode.Teams.Count){
                if(FromTeamId==0){
                    AvailPlayers.Remove(player);
                    Team t = Gamemode.Teams.Find(x=>x.Id==ToTeamId);
                    if(t!=null)t.AddPlayer(player);

                }
                else if(ToTeamId==0){ 
                    Team t = Gamemode.Teams.Find(x=>x.Id==FromTeamId);
                    if(t!=null)t.RemovePlayer(player);
                    AvailPlayers.Add(player);
                }
            }
        }
    }
}
public enum GameState{
    Ready,
    Running,
    Over
}
