using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    public class Pawn : ChessPiece
    {
        public Pawn(Position startPos,ChessPieceType pieceType )
        {
            name = pieceType.ToString();            
            PieceType = pieceType;
            StartPosition = startPos;
        }
        public override void Draw()
        {
            int startX = StartPosition.X;
            int startY = StartPosition.Y;

            Console.SetCursorPosition(startX, startY);
            Console.Write('P');
        }
    }
}
