using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CKS_1._0.Model
{
    public class Gamemode{
        public int Id{get;set;}
        public string Name{get;set;}
        public string Description{get;set;}
        public List<Team> Teams{get;set;}
        public Inventory Settings{get;set;}

        public Mastery Mastery{get;private set;}

        public Gamemode(int id, string name, string description)
        {
            Id=id;
            Name=name;
            Description=Description;
            Teams=new List<Team>();
            Settings = new Inventory();
            Mastery = new Mastery(this);

        }
    }
}