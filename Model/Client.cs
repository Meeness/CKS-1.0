using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model
{
    public class Client
    {
         public ConnectionState ConState {get;set;}
         public IPAddress IP {get;set;}
         public Client()
         {
             
         }
    }
    public enum ConnectionState {
        StateOne,
        StateTwo
    }
}
