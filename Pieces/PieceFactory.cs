using System;
using System.Collections.Generic;
using System.Linq;

namespace chessgame
{
    public class PieceFactory
    {
       // a place where we can construct our list and then call on them from Main
        public List<ChessPiece> Wplayer { get; set; }
        public List<ChessPiece> WhitePlayerList()
        {
            //foreach (var chessPiece in Wplayer)
            //{
            //    Wplayer.Add(new Pawn(new Position(), ));
            //}
            
            return new List<ChessPiece>
            {
                Pawn.CreatePawn(1, 0),
                Pawn.CreatePawn(1, 1),
                Pawn.CreatePawn(1, 2),
                Pawn.CreatePawn(1, 3),
                Pawn.CreatePawn(1, 4),
                Pawn.CreatePawn(1, 5),
                Pawn.CreatePawn(1, 6),
                Pawn.CreatePawn(1, 7),
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
        public List<ChessPiece> BlackPlayerList()
        {
            return new List<ChessPiece>
            {
                Pawn.CreatePawn(7, 0),
                Pawn.CreatePawn(7, 1),
                Pawn.CreatePawn(7, 2),
                Pawn.CreatePawn(7, 3),
                Pawn.CreatePawn(7, 4),
                Pawn.CreatePawn(7, 5),
                Pawn.CreatePawn(7, 6),
                Pawn.CreatePawn(7, 7), 
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
        //public List<ChessPiece> NumberOfPieces(List<ChessPiece> list)
        //{
        //    var number = list.GroupBy(x => x);
        //    List<ChessPiece> newList = new List<ChessPiece>();

        //    foreach (var item in number)
        //    {
        //        string[] stringArray = (item.Key).Split(new char[] {'.'});
        //        Console.WriteLine("{0} X {1} ",stringArray[1],  item.Count());                
        //    }
        //    return newList;
        //}
        //public List<string> KillPiece(List<string> list)
        //{
        //    List<string> newList = new List<string>();
        //    foreach (var item in list)
        //    {
        //        newList.Add(item);
        //    }
        //    for (int i = 0; i < newList.Count; i++)
        //    {
        //        newList.RemoveAt(4);
        //    }
        //    return newList;
        //}
    }
}
