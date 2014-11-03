using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{

    public abstract class ChessPiece : Move
    {
        internal string name;
        internal int AttackValue;
        internal int DefenceValue;
        internal int PieceValue;
        internal int PieceActionValue;
        internal bool Selected;
        internal bool Moved;
        internal Stack<byte> ValidMoves;
        internal TeamColor.Color PieceColor;
        internal ChessPieceType.ChessPieceTypes PieceType;
        internal Position StartPosition;


        public virtual void Draw()
        {

        }






        internal ChessPiece(ChessPiece piece) // konstruktor 
        {

            PieceColor = piece.PieceColor;
            PieceType = piece.PieceType;
            Moved = piece.Moved;
            PieceValue = piece.PieceValue;

            //if (piece.ValidMoves != null)
            //{
            //    LastValidMoveCount = piece.ValidMoves.Count;
            //}
        }

        internal ChessPiece(ChessPieceType.ChessPieceTypes chessPieceType, TeamColor.Color chessPieceColor)
        {

            PieceType = chessPieceType;
            PieceColor = chessPieceColor;
            ValidMoves = new Stack<byte>();
            PieceValue = CalculatePieceValue(PieceType);
        }

        internal ChessPiece()
        {

        }


        internal int CalculatePieceValue(ChessPieceType.ChessPieceTypes pieceType)

        {
            switch (pieceType)
            {
                case ChessPieceType.ChessPieceTypes.Pawn:
                {
                    return 10;
                }
                case ChessPieceType.ChessPieceTypes.Knight:
                {
                    return 25;
                }
                case ChessPieceType.ChessPieceTypes.Bishop:
                {
                    return 30;
                }
                case ChessPieceType.ChessPieceTypes.Rook:
                {
                    return 50;
                }
                case ChessPieceType.ChessPieceTypes.Queen:
                {
                    return 80;
                }
                case ChessPieceType.ChessPieceTypes.King:
                {
                    return 100;
                }
                default:

                    return 0;
            }

        }

        public int CalculatePieceActionValue(ChessPieceType.ChessPieceTypes pieceType)
        {
            switch (pieceType)
            {
                case ChessPieceType.ChessPieceTypes.Pawn:
                {
                    return 10;
                }
                case ChessPieceType.ChessPieceTypes.Knight:
                {
                    return 8;
                }
                case ChessPieceType.ChessPieceTypes.Bishop:
                {
                    return 6;
                }
                case ChessPieceType.ChessPieceTypes.Rook:
                {
                    return 4;
                }
                case ChessPieceType.ChessPieceTypes.Queen:
                {
                    return 2;
                }
                case ChessPieceType.ChessPieceTypes.King:
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
    

