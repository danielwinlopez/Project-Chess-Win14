using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    class Queen : ChessPiece
    {
        public static Queen CreateQueen(int x, int y)
        {
            return new Queen() //TODO: GÖRA KLART
            {
                AttackValue = 7,
                DefenceValue = 14,
                PieceValue = 80,
                name = ChessPieceType.Queen.ToString(),
                PieceActionValue = 2,
                PieceType = ChessPieceType.Queen,
                Position = new Position(x, y),
                GetMove = new Move()
            };
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
