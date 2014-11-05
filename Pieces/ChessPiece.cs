using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    public abstract class ChessPiece
    {
        internal string name;
        internal int AttackValue;
        internal int DefenceValue;
        internal int PieceValue;
        internal int PieceActionValue;
        internal bool Selected;
        internal bool Moved;
        internal Stack<byte> ValidMoves;
        internal Color PieceColor;
        internal ChessPieceType PieceType;
        public static ChessPiece ChessPiecesPiece { get; set; }
        public Position Position { get; set; }
        public virtual void Draw()
        {

        }
        internal ChessPiece(ChessPiece piece) // konstruktor 
        {
            PieceColor = piece.PieceColor;
            PieceType = piece.PieceType;
            Moved = piece.Moved;
            PieceValue = piece.PieceValue;
        }

        public ChessPiece()
        {
            
        }
        internal ChessPiece(ChessPieceType chessPieceType, Color teamColor)
        {
            PieceType = chessPieceType;
            PieceColor = teamColor;
            ValidMoves = new Stack<byte>();
            PieceValue = CalculatePieceValue(PieceType);
        }
      
        internal int CalculatePieceValue(ChessPieceType pieceType)

        {
            switch (pieceType)
            {
                case ChessPieceType.Pawn:
                {
                    return 10;
                }
                case ChessPieceType.Knight:
                {
                    return 25;
                }
                case ChessPieceType.Bishop:
                {
                    return 30;
                }
                case ChessPieceType.Rook:
                {
                    return 50;
                }
                case ChessPieceType.Queen:
                {
                    return 80;
                }
                case ChessPieceType.King:
                {
                    return 100;
                }
                default:

                    return 0;
            }
        }
        public int CalculatePieceActionValue(ChessPieceType pieceType)
        {
            switch (pieceType)
            {
                case ChessPieceType.Pawn:
                {
                    return 10;
                }
                case ChessPieceType.Knight:
                {
                    return 8;
                }
                case ChessPieceType.Bishop:
                {
                    return 6;
                }
                case ChessPieceType.Rook:
                {
                    return 4;
                }
                case ChessPieceType.Queen:
                {
                    return 2;
                }
                case ChessPieceType.King:
                {
                    return 2;
                }
                default:
                {
                    return 0;
                }
            }
        }
    }
}
    

