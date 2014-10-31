using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{

            public abstract class ChessPiece : Move
    {
        
        internal int AttackValue;
        internal int DefenceValue;
        internal int PieceValue;
        internal int PieceActionValue;
        internal bool Selected;
        internal bool Moved;
        internal Stack<byte> ValidMoves;
        internal ChessPieceColor PieceColor;
        internal ChessPieceType PieceType;
        internal Position StartPosition;


        public virtual void Draw()
        {

        }

        
        public enum ChessPieceColor //enum för lagfärger
        {
            White,
            Black
        }
        public enum ChessPieceType // enum för speltyper
        {
            King,
            Queen,
            Rook,
            Bishop,
            Knight,
            Pawn       
        
        }

        internal  ChessPiece(ChessPiece piece) // konstruktor 
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

        internal ChessPiece(ChessPieceType chessPieceType, ChessPieceColor chessPieceColor)
        {
            PieceType = chessPieceType;
            PieceColor = chessPieceColor;
            ValidMoves = new Stack<byte>();
            PieceValue = CalculatePieceValue(PieceType);
        }

        internal ChessPiece()
        {

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
    

