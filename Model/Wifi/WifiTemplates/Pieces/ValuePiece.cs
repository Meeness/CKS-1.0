using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi.WifiTemplates
{
    public class ValuePiece:Piece{
        public ValuePiece(byte[] value, int direction):base(value, direction){}
        public ValuePiece(byte[] value, ReadingDirection direction):base(value, direction){}
        public ValuePiece(byte value):base(value){}
        public ValuePiece(UInt16 value):base(value){}
        public ValuePiece(UInt32 value):base(value){}
        public ValuePiece(long value):base(value){}
        public ValuePiece(string value):base(value){}
        public ValuePiece(DateTime timestamp):base(Piece.ConvertDatetime(timestamp)){}
    }
}