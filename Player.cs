using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    public class Player
    {

        private string teamColor;
        List<ChessPiece> pieces = new List<ChessPiece>();

        public byte PiecesAmount { get; set; }

        public Player(string color)
        {
            this.teamColor = color;
        }
        public List<string> ChessPieceList(List<ChessPiece.ChessPieceType> pieceType)
        {
            
            List<string> pieceList = new List<string>();
           

            foreach (ChessPiece.ChessPieceType item in pieceType)
            {
                pieceList.Add(item.ToString());
            }

            return pieceList;
        }
        public string TimesInList(List<string> list)
        {


            var number = list.GroupBy(x => x);
            string svar = null;
            foreach (var item in number)
            {
                svar = ToString(); Console.WriteLine("{0} finns {1} ", item.Key, item.Count());
            }
            return svar;
        }


       
    }
}
