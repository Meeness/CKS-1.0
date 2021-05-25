using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace CKS_1._0.Model
{
    public class Client
    {
        public ConnectionState ConState {get;set;}
        public IPAddress IP {get;set;}
        public Inventory LWInv {get;set;}
        public Inventory CKInv {get;set;}
        IPEndPoint endPoint {get;set;}

        UdpClient socket = new UdpClient();
        
         
        public Client(IPAddress ip, int port)
        {
            socket.EnableBroadcast = true;
            IP=ip;
            endPoint = new IPEndPoint(IP, port);

        }

    }
    public enum ConnectionState {
        Offline,
        PartlyConnected, //might need to be seperated into 3 states-> GunConnected, MMCUConnected, NoSensorConnected
        Online
    }
}
