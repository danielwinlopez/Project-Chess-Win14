using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    class Knight : ChessPiece
    {
        public static Knight CreateKnight(int x, int y)//Each pieces is given it´s specific values in it´s class
        {
            return new Knight()
            {
                AttackValue = 3,
                DefenceValue = 6,
                PieceValue = 25,
                name = ChessPieceType.Bishop.ToString(),
                PieceActionValue = 8,
                PieceType = ChessPieceType.Bishop,
                Position = new Position(x, y),
                GetMove = new Move().KnightMove()
            };
        }
        public override void Draw()
        {
            int startX = Position.X;
            int startY = Position.Y;

            Console.SetCursorPosition(startX, startY);
            Console.Write('k');
        }
    }
}
