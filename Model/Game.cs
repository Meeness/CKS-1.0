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
            if(Gamemode!=null){
                foreach(Team team in Gamemode.Teams){
                    foreach(Player player in team.Players){
                        team.RemovePlayer(player);
                        player.TeamId=0;
                    }
                }
            }
            Gamemode G =GamemodeList.Find(x=>x.Id==id);
            if(G!=null)Gamemode=G;
        }
        public void ChangeTeam(Player player, int ToTeamId){
            if(player.TeamId<=Gamemode.Teams.Count||ToTeamId<=Gamemode.Teams.Count){
                if(player.TeamId==0){
                    AvailPlayers.Remove(player);
                    Team t = Gamemode.Teams.Find(x=>x.Id==ToTeamId);
                    if(t!=null)t.AddPlayer(player);
                    player.TeamId=ToTeamId; // might need to be refrence

                }
                else if(ToTeamId==0){ 
                    Team t = Gamemode.Teams.Find(x=>x.Id==player.TeamId);
                    if(t!=null)t.RemovePlayer(player);
                    AvailPlayers.Add(player);
                    player.TeamId=0; // might need to be refrence

                }
                else{
                    Team t = Gamemode.Teams.Find(x=>x.Id==player.TeamId);
                    Team t2 = Gamemode.Teams.Find(x=>x.Id==ToTeamId);
                    if(t!=null&&t2!=null){
                        t.RemovePlayer(player);
                        t2.AddPlayer(player);
                        player.TeamId=ToTeamId;
                    }
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
