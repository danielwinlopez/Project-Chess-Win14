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
        public string name { get; set; }
        PieceFactory newPieces = new PieceFactory();
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
        public List<ChessPiece> ShowPieces() // White and black player gets a list of pieces according to their color
        {
            if (Color.Black == teamColor)
            {
                return newPieces.BlackPlayerList();                
            }
            else
            {
                return newPieces.WhitePlayerList();
            }
        }
    }
}
