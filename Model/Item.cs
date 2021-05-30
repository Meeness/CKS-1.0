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
        public List<byte[]> AllowedValues {get;set;}
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
        public Item(byte id, int direction, byte[] rangeStart, byte[] rangeEnd, int rangeGrowth=1){
            Id=id;
            ReadDirection = (ReadingDirection)direction;
            Value=new byte[]{};
            AllowedValues=CalcAllowedValues(rangeStart, rangeEnd, rangeGrowth);
        }
        public Item(byte id, int direction, List<byte[]> allowedValues){
            Id=id;
            ReadDirection = (ReadingDirection)direction;
            Value=new byte[]{};
            AllowedValues=allowedValues;
        }
        public Item(byte id){
            Id=id;
            Value=new byte[]{};
        }

        /*public void SetAllowedValues(byte[] rangeStart, byte[] rangeEnd, byte[] rangeGrowth){
            //int len = rangeStart.Length>rangeEnd.Length?rangeStart.Length:rangeEnd.Length;
            double start = Convert.ToInt32(rangeStart);
            double end = Convert.ToInt32(rangeEnd);
            double growth = Convert.ToInt32(rangeGrowth);
            double d = (end - start)/growth;
            int len = Convert.ToInt32(Math.Ceiling(d));
            
            byte[][] returnArray = new byte[len][];
            int i = 0;
            for(double k = start;k<=end;k+=growth){
                returnArray[i] = BitConverter.GetBytes(k);

                i++;
            }
            AllowedValues=returnArray;
        }*/
        public static byte[] ReverseBytes(byte[] bytes)
        {
            int len = bytes.Length;
            int j = len;
            byte[] returnBytes = new byte[len];
            for(int i = 0;i<len;i++){
                j--;
                returnBytes[i] = bytes[j];           
            }
            return returnBytes;
        }
        public List<byte[]> CalcAllowedValues(byte[] start, byte[] end, int growth){
            int s = Convert.ToInt32(start);
            int e = Convert.ToInt32(end);
            List<byte[]> returnlist = new List<byte[]>{};
            for(int i = s;i<=e;i+=growth){
                returnlist.Add(BitConverter.GetBytes(i));
            }

            return returnlist;
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