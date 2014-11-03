using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    public class Pawn : ChessPiece
    {
        private string P;

        public Pawn(Position startPos)
        {
            StartPosition = startPos;
        }

        public Pawn(string p)
        {
            // TODO: Complete member initialization
            this.P = p;
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
