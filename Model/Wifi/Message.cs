using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CKS_1._0.Model.Wifi.WifiTemplates;

namespace CKS_1._0.Model.Wifi
{
    public abstract class Message{
        
        public List<Block> Blocks {get;set;}

        public Message(byte classification, byte msgcount, bool IsLW = true )
        {
            Blocks = new List<Block>();
            if(IsLW)Blocks.Add(new WaterMark("<LW>"));
            else Blocks.Add(new WaterMark("<CK>"));
            Blocks.Add(new IdentifierBlock(classification, msgcount));
        }
        public byte[] CombinedMessage()
        {
            byte[][] blockArr = new byte[Blocks.Count][];
            for(int i = 0;i<Blocks.Count;i++){
                byte[][] pieceArr = new byte[Blocks[i].Pieces.Count][];
                for(int j = 0;j<Blocks[i].Pieces.Count;j++){
                    pieceArr[j] = Blocks[i].Pieces[j].Bytes;
                }
                blockArr[i] = Combine(pieceArr);
            }
            return Combine(blockArr);
        }
        private byte[] Combine(params byte[][] arrays)
        {
            byte[] rv = new byte[arrays.Sum(a => a.Length)];
            int offset = 0;
            foreach (byte[] array in arrays) {
                System.Buffer.BlockCopy(array, 0, rv, offset, array.Length);
                offset += array.Length;
            }
            return rv;
        }

    }
}