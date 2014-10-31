using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    public class PieceFactory
    {
       // a place where we can construct our list and then call on them from Main
        public List<ChessPiece> PlayerList()
        {
            List<ChessPiece> collection = new List<ChessPiece>();
            collection.Add(new Pawn("P1"));
            collection.Add(new Pawn("P2"));
            collection.Add(new Pawn("P3"));
            collection.Add(new Pawn("P4"));
            collection.Add(new Pawn("P5"));
            collection.Add(new Pawn("P6"));
            collection.Add(new Pawn("P7"));
            collection.Add(new Pawn("P8"));
            collection.Add(new Bishop("B1"));
            collection.Add(new Bishop("B2"));
            collection.Add(new Rook("R1"));
            collection.Add(new Rook("R2"));
            collection.Add(new Knight("k1"));
            collection.Add(new Knight("k2"));
            collection.Add(new Queen("Q"));
            collection.Add(new King("K"));
            
            List<ChessPiece> startcollection = new List<ChessPiece>();
            foreach (var item in collection)
            {
                for (int i = 0; i < collection.Count; i++)
                {
                    startcollection.Add(item); 
                }
                
            }
            return startcollection;
        } 
        
        
    }
}
