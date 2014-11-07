using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    class Rook : ChessPiece
    {

        public static Rook CreateRook(int x, int y)//Each pieces is given it´s specific values in it´s class
        {
            return new Rook()
            {
                AttackValue = 5,
                DefenceValue = 10,
                PieceValue = 50,
                name = ChessPieceType.Rook.ToString(),
                PieceActionValue = 4,
                PieceType = ChessPieceType.Rook,
                Position = new Position(x, y),
                GetMove = new Move(new Position(x, y)).RookMove()
            };
        }
        public override void Draw()
        {
            int startX = Position.X;
            int startY = Position.Y;

            Console.SetCursorPosition(startX, startY);
            Console.Write('R');
        }
    }
}
