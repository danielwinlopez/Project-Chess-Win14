using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    class Bishop : ChessPiece
    {

        public static Bishop CreateBishop(int x, int y)
        {
            return new Bishop() //TODO: GÖRA KLART
            {
                AttackValue = 4,
                DefenceValue = 8,
                PieceValue = 30,
                name = ChessPieceType.Bishop.ToString(),
                PieceActionValue = 6,
                PieceType = ChessPieceType.Bishop,
                Position = new Position(x,y),
                GetMove = new Move(),
                
            };
        }
        /* VET INTE OM DETTA ÄR OPTIMALT (ELLER ENS FUNGERAR ATT ANVÄNDA)
        public List<Position> possibleMove = new List<Position>
        {
            new Position(1, 1),
            new Position(2, 2),
            new Position(3, 3),
            new Position(4, 4),
            new Position(5, 5),
            new Position(6, 6),
            new Position(7, 7),
            new Position(8, 8),
            new Position(1, -1),
            new Position(2, -2),
            new Position(3, -3),
            new Position(4, -4),
            new Position(5, -5),
            new Position(6, -6),
            new Position(7, -7),
            new Position(8, -8),
            new Position(-1, -1),
            new Position(-2, -2),
            new Position(-3, -3),
            new Position(-4, -4),
            new Position(-5, -5),
            new Position(-6, -6),
            new Position(-7, -7),
            new Position(-8, -8),
            new Position(-1, -1),
            new Position(-2, -2),
            new Position(-3, -3),
            new Position(-4, -4),
            new Position(-5, -5),
            new Position(-6, -6),
            new Position(-7, -7),
            new Position(-8, -8),
        };

         */
        public override void Draw()
        {
            int startX = Position.X;
            int startY = Position.Y;

            Console.SetCursorPosition(startX, startY);
            Console.Write('B');
        }
    }
}
