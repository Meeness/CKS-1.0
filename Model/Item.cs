using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model
{
    public class Item{
        public byte Id{get;set;}
        public byte[] Value{get;set;}
        public ReadingDirection ReadDirection{get;set;}
        public Item(byte id, byte[] value, int read = 0)
        {
            Id=id;
            Value=value;
            ReadDirection = (ReadingDirection)read;
        }
        public Item(byte id, byte[] value, ReadingDirection direction){
            Id=id;
            Value=value;
            ReadDirection = direction;
        }
        public Item(byte id, string s){
            Value = new byte[]{};
            foreach(char c in s ){
                Value=AddByteToArrayEnd(Value, Convert.ToByte(c));
            }
            ReadDirection = ReadingDirection.Forwards;
        }


        //methods
        public byte[] AddByteToArrayEnd(byte[] bytes, byte newByte){
            byte[] newArray = new byte[bytes.Length + 1];
            bytes.CopyTo(newArray, 0);
            newArray[bytes.Length] = newByte;
            return newArray;
        }

    }
    public enum ReadingDirection{
        Forwards = 0,
        Backwards
    }
}