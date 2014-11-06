using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    public class Pawn : ChessPiece
    {
        public static Pawn CreatePawn(int x, int y)
        {
            //Each pieces is given it´s specific values in it´s class
            return new Pawn() //TODO: GÖRA KLART
            {
                AttackValue = 1,
                DefenceValue = 2,
                PieceValue = 10,
                name = ChessPieceType.Pawn.ToString(),
                PieceActionValue = 10,
                PieceType = ChessPieceType.Pawn,
                Position = new Position(x, y),
                GetMove = new Move().PawnMove()
            };
        }
        public override void Draw()
        {
            int startX = Position.X;
            int startY = Position.Y;

            Console.SetCursorPosition(startX, startY);
            Console.Write('P');
        }
    }
}
