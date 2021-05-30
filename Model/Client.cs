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

        public Inventory LWInv {get;set;} //laserwar inventory
        public Inventory LWInvAll {get;set;} //entire laserwar inventory
        public Inventory CKInv {get;set;} //combatkarts inventory

        public IPEndPoint endPoint {get;set;}
        public UdpClient Socket {get;set;}
        
        private byte _msgcount = 0x00;
        public byte Msgcount{
            get{
                byte returnValue = _msgcount;
                if(_msgcount<0xff)_msgcount += 1;
                else _msgcount = 0x00;
                return returnValue;
            }
        }
         
        public Client(IPAddress ip, int port)
        {
            LWInv = new Inventory();
            LWInvAll = new Inventory();
            CKInv = new Inventory();
            endPoint = new IPEndPoint(ip, port);
            Socket = new UdpClient(endPoint);
            Socket.EnableBroadcast = true;
            ConState = ConnectionState.Connecting;

        }

    }
    public enum ConnectionState {
        Offline,
        Connecting, 
        Authenticated,
        Initialized,
        PartlyConnected, //might need to be seperated into 3 states-> GunConnected, MMCUConnected, NoSensorConnected
        Online
    }
}
