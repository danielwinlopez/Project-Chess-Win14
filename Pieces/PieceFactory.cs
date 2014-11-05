using System;
using System.Collections.Generic;
using System.Linq;

namespace chessgame
{
    public class PieceFactory
    {
       // a place where we can construct our list and then call on them from Main

        public List<ChessPiece> WhitePlayerList()
        {
            return new List<ChessPiece>
            {
                new Pawn(new Position(1, 0), ChessPieceType.Pawn),
                new Pawn(new Position(1, 1), ChessPieceType.Pawn),
                new Pawn(new Position(1, 2), ChessPieceType.Pawn),
                new Pawn(new Position(1, 3), ChessPieceType.Pawn),
                new Pawn(new Position(1, 4), ChessPieceType.Pawn),
                new Pawn(new Position(1, 5), ChessPieceType.Pawn),
                new Pawn(new Position(1, 6), ChessPieceType.Pawn),
                new Pawn(new Position(1, 7), ChessPieceType.Pawn),
                new Bishop(new Position(2, 0), ChessPieceType.Bishop),
                new Bishop(new Position(5, 0), ChessPieceType.Bishop),
                new Rook(new Position(0, 0), ChessPieceType.Rook),
                new Rook(new Position(7, 0), ChessPieceType.Rook),
                new Knight(new Position(1, 0), ChessPieceType.Knight),
                new Knight(new Position(6, 0), ChessPieceType.Knight),
                new Queen(new Position(4, 0), ChessPieceType.Queen),
                new King(new Position(3, 0) , ChessPieceType.King)
            };
        }
        public List<ChessPiece> BlackPlayerList()
        {
            return new List<ChessPiece>
            {
                new Pawn(new Position(7, 0), ChessPieceType.Pawn),
                new Pawn(new Position(7, 1), ChessPieceType.Pawn),
                new Pawn(new Position(7, 2), ChessPieceType.Pawn),
                new Pawn(new Position(7, 3), ChessPieceType.Pawn),
                new Pawn(new Position(7, 4), ChessPieceType.Pawn),
                new Pawn(new Position(7, 5), ChessPieceType.Pawn),
                new Pawn(new Position(7, 6), ChessPieceType.Pawn),
                new Pawn(new Position(7, 7), ChessPieceType.Pawn),
                new Bishop(new Position(2, 8), ChessPieceType.Bishop),
                new Bishop(new Position(5, 8), ChessPieceType.Bishop),
                new Rook(new Position(0, 8), ChessPieceType.Rook),
                new Rook(new Position(7, 8), ChessPieceType.Rook),
                new Knight(new Position(1, 8), ChessPieceType.Knight),
                new Knight(new Position(6, 8), ChessPieceType.Knight),
                new Queen(new Position(3, 8), ChessPieceType.Queen),
                new King(new Position(4, 8) , ChessPieceType.King)
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
