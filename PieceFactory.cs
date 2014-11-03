using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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
            var pieceList = new List<ChessPiece>
            {
                new Pawn(new Position(1, 0), ChessPieceType.ChessPieceTypes.Pawn),
                new Pawn(new Position(1, 1), ChessPieceType.ChessPieceTypes.Pawn),
                new Pawn(new Position(1, 2), ChessPieceType.ChessPieceTypes.Pawn),
                new Pawn(new Position(1, 3), ChessPieceType.ChessPieceTypes.Pawn),
                new Pawn(new Position(1, 4), ChessPieceType.ChessPieceTypes.Pawn),
                new Pawn(new Position(1, 5), ChessPieceType.ChessPieceTypes.Pawn),
                new Pawn(new Position(1, 6), ChessPieceType.ChessPieceTypes.Pawn),
                new Pawn(new Position(1, 7), ChessPieceType.ChessPieceTypes.Pawn),
                new Bishop(new Position(2, 0), ChessPieceType.ChessPieceTypes.Bishop),
                new Bishop(new Position(5, 0), ChessPieceType.ChessPieceTypes.Bishop),
                new Rook(new Position(0, 0), ChessPieceType.ChessPieceTypes.Rook),
                new Rook(new Position(7, 0), ChessPieceType.ChessPieceTypes.Rook),
                new Knight(new Position(1, 0), ChessPieceType.ChessPieceTypes.Knight),
                new Knight(new Position(6, 0), ChessPieceType.ChessPieceTypes.Knight),
                new Queen(new Position(4, 0), ChessPieceType.ChessPieceTypes.Queen),
                new King(new Position(3, 0) , ChessPieceType.ChessPieceTypes.King)
            };

            var startcollection = new List<string>();
            
            foreach (var item in pieceList)
            {               
                startcollection.Add(item.ToString());             
            }

            return startcollection;
        }

        public List<string> NumberOfPieces(List<string> list)
        {
            var number = list.GroupBy(x => x);
            List<string> newList = new List<string>();

            foreach (var item in number)
            {
                string[] stringArray = (item.Key).Split(new char[] {'.'});
                Console.WriteLine("{0} X {1} ",stringArray[1],  item.Count());                
            }

            return newList;
        }


        
        
    }
}
