using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Numerics;

namespace CKS_1._0.Model.Wifi
{
    public abstract class Piece{
        
        public byte[] Bytes {get;private set;}
        public ReadingDirection ReadDirection {get; private set;}

        public Piece( byte[] bytes, int direction) //byte[]
        {
            ReadDirection = (ReadingDirection)direction;
            Bytes = bytes;
        }
        public Piece( byte[] bytes, ReadingDirection direction) //byte[]
        {
            ReadDirection = direction;
            Bytes = bytes;
        }

        public Piece(byte i)//1 byte
        {
            ReadDirection = ReadingDirection.Forwards; 
            Bytes = BitConverter.GetBytes(i);
        }
        public Piece(UInt16 i)//2 bytes
        {
            ReadDirection = ReadingDirection.Backwards; 
            Bytes = BitConverter.GetBytes(i);                 
        }
        public Piece(UInt32 i)//4 bytes
        {
            ReadDirection = ReadingDirection.Backwards; 
            Bytes = BitConverter.GetBytes(i);
        }
        public Piece(long i)//8 bytes
        {
            ReadDirection = ReadingDirection.Backwards; 
            Bytes = BitConverter.GetBytes(i);
        }
        public Piece(string s)//string
        {
            ReadDirection = ReadingDirection.Forwards;
            foreach(char c in s){
                Bytes=AddByteToArrayEnd(Bytes, Convert.ToByte(c));
            }
        }


        //methods
        public static long ConvertDatetime(DateTime dateTime)//datetime->ldap convert
        {
            long d = new DateTime(1601, 01, 01, 0, 0, 0, DateTimeKind.Local).Ticks;
            long n = DateTime.Now.Ticks;
            long b = n-d;
            return b;
        }
        public byte[] AddByteToArrayEnd(byte[] bytes, byte newByte){
            byte[] newArray = new byte[bytes.Length + 1];
            bytes.CopyTo(newArray, 0);
            newArray[bytes.Length] = newByte;
            return newArray;
        }
  
    }

    
}