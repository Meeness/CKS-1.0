using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CKS_1._0.Model
{
    public class Mastery{
        public List<Discipline> Disciplines {get;private set;}
        public Mastery(Gamemode gamemode)
        {
            Disciplines = new List<Discipline>{};
            Disciplines.Add(new Discipline(1, "Most Brutal", gamemode)); //Most Brutal
            Disciplines.Add(new Discipline(2, "Most Accurate", gamemode)); //Most Accurate
            Disciplines.Add(new Discipline(3, "Most Protective", gamemode)); //Most Protective
        }

    }
}