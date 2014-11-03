using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    class Bishop : ChessPiece
    {
        private string B;

        public Bishop(Position startPos)
        {
            StartPosition = startPos;
        }

        public Bishop(string b)
        {
            // TODO: Complete member initialization
            this.B = b;
        }

        public override void Draw()
        {
            int startX = StartPosition.X;
            int startY = StartPosition.Y;

            Console.SetCursorPosition(startX, startY);
            Console.Write('B');
        }
    }
}
