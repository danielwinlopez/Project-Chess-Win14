using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    class Queen : ChessPiece
    {
        private string Q;

        public Queen(Position startPos)
        {
            StartPosition = startPos;
        }

        public Queen(string q)
        {
            // TODO: Complete member initialization
            this.Q = q;
        }

        public override void Draw()
        {
            int startX = StartPosition.X;
            int startY = StartPosition.Y;

            Console.SetCursorPosition(startX, startY);
            Console.Write('Q');
        }
    }
}
