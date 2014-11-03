using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    class Rook : ChessPiece
    {
        private string R;

        public Rook(Position startPos)
        {
            StartPosition = startPos;
        }

        public Rook(string r)
        {
            // TODO: Complete member initialization
            this.R = r;
        }

        public override void Draw()
        {
            int startX = StartPosition.X;
            int startY = StartPosition.Y;

            Console.SetCursorPosition(startX, startY);
            Console.Write('R');
        }
    }
}
