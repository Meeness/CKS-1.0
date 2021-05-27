using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CKS_1._0.Model.Wifi
{
    public class Block{
        public List<Piece> Pieces {get;set;}
        public Block(Piece piece)
        {
            Pieces = new List<Piece>();
            Pieces.Add(piece);
        }
        public Block(Piece p1, Piece p2){
            Pieces = new List<Piece>();
            Pieces.Add(p1);
            Pieces.Add(p2);
        }
        public Block(List<Piece> pieces){
            Pieces=pieces;
        }
    }
    
}