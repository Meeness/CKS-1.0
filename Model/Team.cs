using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CKS_1._0.Model
{
    public class Team{
        public int Id{get;set;}
        public string Name{get;set;}
        public List<Player> Players {get;set;}
        public Team(int id, string name)
        {
            Id=id;
            Name=name; 
            Players= new List<Player>(); 
        }
        public void AddPlayer(Player player){
            Players.Add(player);
        }
        public void RemovePlayer(Player player){
            Players.Remove(player);
        }
    }
}