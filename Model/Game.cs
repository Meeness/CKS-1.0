using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CKS_1._0.Model.Wifi;
using CKS_1._0.Model.Wifi.WifiTemplates;

namespace CKS_1._0.Model
{
    public class Game
    {
        public int Id{get;set;}
        public GameState State {get;set;}
        public Gamemode Gamemode {get;set;}
        public List<Gamemode> GamemodeList {get;set;}

        public DateTime GameStart{get;set;} 
        public double GameDuration{get;set;}
        public double GameDelay{get;set;}

        public long RemainingGameTime{get;set;}
        
        public List<Player> AvailPlayers{get;set;}


        public Game(List<Gamemode> gamemodes, List<Player> clients)
        {
            GamemodeList = gamemodes;
            GetAvailPlayers(clients);
            State = GameState.Ready;
            GameDuration=15;
            GameDelay=5;
            SelectGameMode(1);
        }
        public void SelectGameMode(int id){
            ClearTeams();
            Gamemode G =GamemodeList.Find(x=>x.Id==id);
            if(G!=null)Gamemode=G;
        }
        public void ClearTeams(){
            if(Gamemode!=null){
                foreach(Team team in Gamemode.Teams){

                    foreach(Player player in team.Players){
                        player.TeamId=0;
                        AvailPlayers.Add(player);
                    }
                    team.Players=new List<Player>();
                }
            }
        }
        public void GetAvailPlayers(List<Player> clients){
            AvailPlayers=new List<Player>{};
            foreach (Player player in clients)
            {
                if(player.Client.ConState==ConnectionState.GameReady)AvailPlayers.Add(player);
            }
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
        public void StartGame(WifiHandler wifiHandler){
            GameStart = DateTime.Now.AddSeconds(GameDelay);
            State = GameState.Running;
            foreach(Team team in Gamemode.Teams){
                foreach(Player player in team.Players){
                    Inventory inv = new Inventory();
                    byte teamid = Convert.ToByte(player.TeamId-1);
                    if(player.Client.LWInv.Items.Find(x=>x.Id==0x15).Value[0]!=teamid)inv.Items.Add(new Item(0x15, new byte[]{teamid}));
                    foreach(Item item in player.Client.LWInv.Items){
                        foreach(Item setting in Gamemode.Settings.Items){
                            if(setting.Id==item.Id&&!setting.Value.SequenceEqual(item.Value))inv.Items.Add(setting);
                        }
                    }
                    
                    if(inv.Items.Count>0)wifiHandler.SendMessage(new GamemodeItemUpdateMessage(player.Client.Msgcount, inv), player.Client);

                    wifiHandler.SendMessage(new GameMessage(player.Client.Msgcount, true, GameStart, Convert.ToUInt32(GameDuration*60000)), player.Client);
                }
            }
        }
        public void EndGame(WifiHandler wifiHandler){
            State = GameState.Over;
            RemainingGameTime = GetRemainingGameTicks();
            foreach(Team team in Gamemode.Teams){
                foreach(Player player in team.Players){
                    wifiHandler.SendMessage(new GameMessage(player.Client.Msgcount, false), player.Client);
                }
            }
        }
        public long GetRemainingGameTicks(){
            return GameStart.AddMinutes(GameDuration).Ticks-DateTime.Now.Ticks;
        }
        public bool IsGameOver(){
            if(GetRemainingGameTicks()<=0)return true;
            return false;
        }
    }
}
public enum GameState{
    Ready = 0,
    Running,
    Paused,
    Over
}
