using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    class Bishop : ChessPiece
    {
        public static Bishop CreateBishop(int x, int y)//Each pieces is given it´s specific values in it´s class
        {
            return new Bishop()
            {
                AttackValue = 4,
                DefenceValue = 8,
                PieceValue = 30,
                name = ChessPieceType.Bishop.ToString(),
                PieceActionValue = 6,
                PieceType = ChessPieceType.Bishop,
                Position = new Position(x,y),
                GetMove = new Move().BishopMove()
            };
        }
        public override void Draw()
        {
            int startX = Position.X;
            int startY = Position.Y;

            Console.SetCursorPosition(startX, startY);
            Console.Write('B');
        }
    }
}
