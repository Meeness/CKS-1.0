using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CKS_1._0.Model
{
    public class Discipline{
        public int Id{get;set;}
        public string Name {get;set;}
        private Gamemode Gamemode{get;set;}


        public Discipline(int id, string name, Gamemode gamemode)
        {
            Id=id;
            Name=name;
            Gamemode=gamemode;
        }
        public Player GetChampion(){
            Player p = new Player();
                bool found = false;
                bool firstTime = true;
                foreach (Team team in Gamemode.Teams)
                {
                    foreach (Player player in team.Players)
                    {
                        if(firstTime)
                        {
                            p=player;
                            firstTime=false;
                            found=true;
                        }
                        if(player.Performance.Stats[Id].GetValue()>p.Performance.Stats[Id].GetValue())
                        {
                            p=player;
                        }
                    }
                }
                if(found) return p;
                else return null;
        }

    }
}