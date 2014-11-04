using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    public class Player
    {
        private readonly Color teamColor;
        List<string> pieces = new List<string>();
        private string name;
        PieceFactory newPieces = new PieceFactory();
        // Property to keep track on the amount of pieces the player got left

        public byte PiecesAmount { get; set; }

        public Player(Color color)
        {
            teamColor = color;
        }

        public List<string> ChessPieceList(List<string> pieceType)
        {
            pieces = new List<string>();
            foreach (var item in pieceType)
            {
                pieces.Add(item);
            }

            return pieces;
        }
        public List<string> ShowPieces() // lista till varje lag
        {
            if (Color.Black == teamColor)
            {
                return newPieces.NumberOfPieces(newPieces.BlackPlayerList());                
            }
            else
            {
                return newPieces.NumberOfPieces(newPieces.WhitePlayerList());
            }
        }
    }
}
