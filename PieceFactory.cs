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
            var collection = new List<ChessPiece>();

            collection.Add(new Pawn(new Position(1, 0), ChessPieceType.ChessPieceTypes.Pawn, ChessPieceColor.ChessPieceColors.Black));
            collection.Add(new Pawn(new Position(1, 1), ChessPieceType.ChessPieceTypes.Pawn, ChessPieceColor.ChessPieceColors.Black));
            collection.Add(new Pawn(new Position(1, 2), ChessPieceType.ChessPieceTypes.Pawn, ChessPieceColor.ChessPieceColors.Black));
            collection.Add(new Pawn(new Position(1, 3), ChessPieceType.ChessPieceTypes.Pawn, ChessPieceColor.ChessPieceColors.Black));
            collection.Add(new Pawn(new Position(1, 4), ChessPieceType.ChessPieceTypes.Pawn, ChessPieceColor.ChessPieceColors.Black));
            collection.Add(new Pawn(new Position(1, 5), ChessPieceType.ChessPieceTypes.Pawn, ChessPieceColor.ChessPieceColors.Black));
            collection.Add(new Pawn(new Position(1, 6), ChessPieceType.ChessPieceTypes.Pawn, ChessPieceColor.ChessPieceColors.Black));
            collection.Add(new Pawn(new Position(1, 7), ChessPieceType.ChessPieceTypes.Pawn, ChessPieceColor.ChessPieceColors.Black));
            collection.Add(new Bishop(new Position(2,0)));
            collection.Add(new Bishop(new Position(5,0)));
            collection.Add(new Rook(new Position(0,0)));
            collection.Add(new Rook(new Position(7,0)));
            collection.Add(new Knight(new Position(1,0)));
            collection.Add(new Knight(new Position(6,0)));
            collection.Add(new Queen(new Position(4,0)));
            collection.Add(new King(new Position(3,0)));

            var startcollection = new List<string>();
            
            foreach (var item in collection)
            {               
                startcollection.Add(item.ToString());             
            }

            return startcollection;
        }

        public List<string> TimesInList(List<string> list)
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
