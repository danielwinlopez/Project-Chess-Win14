using System;
using System.Collections.Generic;
using System.Linq;

namespace chessgame
{
    public class PieceFactory
    {
       // a place where we can construct our list´s and then call on them from Main
        public List<ChessPiece> Wplayer { get; set; }
        public List<ChessPiece> WhitePlayerList()// Whiteplayer´s list is made here with hardcoded startingpostitions
        {
            return new List<ChessPiece>
            {
                Pawn.CreatePawn(0,1),
                Pawn.CreatePawn(1,1),
                Pawn.CreatePawn(2,1),
                Pawn.CreatePawn(3,1),
                Pawn.CreatePawn(4,1),
                Pawn.CreatePawn(5,1),
                Pawn.CreatePawn(6,1),
                Pawn.CreatePawn(7,1),
                Bishop.CreateBishop(2, 0),
                Bishop.CreateBishop(5, 0),
                Rook.CreateRook(0, 0),
                Rook.CreateRook(7, 0),
                Knight.CreateKnight(1, 0),
                Knight.CreateKnight(6, 0),
                Queen.CreateQueen(4, 0),
                King.CreateKing(3, 0)                
            };
        }
        public List<ChessPiece> BlackPlayerList()// Blackplayer´s list is made here with hardcoded startingpostitions
        {
            return new List<ChessPiece>
            {
                Pawn.CreatePawn( 0,7),
                Pawn.CreatePawn( 1,7),
                Pawn.CreatePawn( 2,7),
                Pawn.CreatePawn( 3,7),
                Pawn.CreatePawn( 4,7),
                Pawn.CreatePawn( 5,7),
                Pawn.CreatePawn( 6,7),
                Pawn.CreatePawn( 7,7), 
                Bishop.CreateBishop(2, 8),
                Bishop.CreateBishop(5, 8),
                Rook.CreateRook(0, 8),
                Rook.CreateRook(7, 8),
                Knight.CreateKnight(1, 8),
                Knight.CreateKnight(6, 8),
                Queen.CreateQueen(3, 8),
                King.CreateKing(4, 8)                    
            };
        }
    }
}
