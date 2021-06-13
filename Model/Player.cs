using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model
{
    public class Player{
        private static int _autoIncrement = 1;
        
        //public int Id{get;private set;}
        public int TeamId {get;set;}
        public Client Client{get;set;}

        public Performance Performance{get;set;}
        
        public Player(Client client)
        {
            //Id=_autoIncrement;
            
            
            Client=client;
            TeamId=0;

            Client.CKInv.Items.Add(new Item(1, "Player"+_autoIncrement));
            Client.CKInv.Items.Add(new Item(2, new byte[]{0x05}));
            Client.CKInv.Items.Add(new Item(3, new byte[]{0x1e}));
            Performance = new Performance(client);


            _autoIncrement++;
        }
        public Player(){}
    }
}