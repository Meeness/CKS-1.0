using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model
{
    public class Player{
        private static int _autoIncrement = 1;
        public int Id{get;private set;}
        public int TeamId {get;set;}
        public Client Client{get;set;}
        public Player(Client client)
        {
            Id=_autoIncrement;
            _autoIncrement++;
            Client=client;
            TeamId=0;
        }
    }
}