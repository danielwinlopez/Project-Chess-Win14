using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    class Queen : ChessPiece
    {
        public Queen(Position startPos, ChessPieceType pieceType)
        {
            Position = startPos;
            name = pieceType.ToString();
            PieceType = pieceType;
        }
        public override void Draw()
        {
            int startX = Position.X;
            int startY = Position.Y;

            Console.SetCursorPosition(startX, startY);
            Console.Write('Q');
        }
    }
}
