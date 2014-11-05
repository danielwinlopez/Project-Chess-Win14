using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    public class PieceValues
    {
        public ChessPieceType type { get; set; }

        public PieceValues(ChessPieceType pieceType)
        {
            type = pieceType;
        }
        public int CalculatePieceValue(ChessPieceType pieceType)

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
                    return 300;
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
        public int CalculateDefenceValue(ChessPieceType pieceType) //sets defence value to pieces(working together adds upp)
        {
            switch (pieceType)
            {
                case ChessPieceType.Pawn:
                    {
                        return 2;
                    }
                case ChessPieceType.Knight:
                    {
                        return 6;
                    }
                case ChessPieceType.Bishop:
                    {
                        return 8;
                    }
                case ChessPieceType.Rook:
                    {
                        return 10;
                    }
                case ChessPieceType.Queen:
                    {
                        return 14;
                    }
                case ChessPieceType.King:
                    {
                        return 1;
                    }
                default:

                    return 0;
            }
        }
        public int CalculateAttackValue(ChessPieceType pieceType) //sets attack value to pieces(working together adds upp)
        {
            switch (pieceType)
            {
                case ChessPieceType.Pawn:
                    {
                        return 1;
                    }
                case ChessPieceType.Knight:
                    {
                        return 3;
                    }
                case ChessPieceType.Bishop:
                    {
                        return 4;
                    }
                case ChessPieceType.Rook:
                    {
                        return 5;
                    }
                case ChessPieceType.Queen:
                    {
                        return 7;
                    }
                case ChessPieceType.King:
                    {
                        return 1;
                    }
                default:

                    return 0;
            }
        }
    }
}
