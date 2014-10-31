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
        public List<string> PlayerList()
        {
            List<ChessPiece> collection = new List<ChessPiece>();

            collection.Add(new Pawn(new Position(1, 0), ChessPiece.ChessPieceType.Pawn, ChessPiece.ChessPieceColor.Black));
            collection.Add(new Pawn(new Position(1, 1), ChessPiece.ChessPieceType.Pawn, ChessPiece.ChessPieceColor.Black));
            collection.Add(new Pawn(new Position(1, 2), ChessPiece.ChessPieceType.Pawn, ChessPiece.ChessPieceColor.Black));
            collection.Add(new Pawn(new Position(1, 3), ChessPiece.ChessPieceType.Pawn, ChessPiece.ChessPieceColor.Black));
            collection.Add(new Pawn(new Position(1, 4), ChessPiece.ChessPieceType.Pawn, ChessPiece.ChessPieceColor.Black));
            collection.Add(new Pawn(new Position(1, 5), ChessPiece.ChessPieceType.Pawn, ChessPiece.ChessPieceColor.Black));
            collection.Add(new Pawn(new Position(1, 6), ChessPiece.ChessPieceType.Pawn, ChessPiece.ChessPieceColor.Black));
            collection.Add(new Pawn(new Position(1, 7), ChessPiece.ChessPieceType.Pawn, ChessPiece.ChessPieceColor.Black));
            collection.Add(new Bishop(new Position(2,0)));
            collection.Add(new Bishop(new Position(5,0)));
            collection.Add(new Rook(new Position(0,0)));
            collection.Add(new Rook(new Position(7,0)));
            collection.Add(new Knight(new Position(1,0)));
            collection.Add(new Knight(new Position(6,0)));
            collection.Add(new Queen(new Position(4,0)));
            collection.Add(new King(new Position(3,0)));
            
            List<string> startcollection = new List<string>();
            foreach (ChessPiece item in collection)
            {
                for (int i = 0; i < 1; i++)
                {
                    startcollection.Add(item.ToString()); 
                }
                
            }
            return startcollection;
        } 
        
        
    }
}
