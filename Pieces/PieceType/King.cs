using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    public class King : ChessPiece
    {
        public static King CreateKing(int x, int y)
        {
            return new King() //TODO: GÖRA KLART
            {
                AttackValue = 1,
                DefenceValue = 1,
                PieceValue = 300,
                name = ChessPieceType.King.ToString(),
                PieceActionValue = 1,
                PieceType = ChessPieceType.King,
                Position = new Position(x,y),
                GetMove = new Move()
            };
        }
        public override void Draw()
        {
            int startX = Position.X;
            int startY = Position.Y;

            Console.SetCursorPosition(startX, startY);
            Console.Write('K');
        }
    }
}
