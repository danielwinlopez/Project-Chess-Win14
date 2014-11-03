using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    class Knight : ChessPiece
    {
        private string Horse;

        public Knight(Position startPos)
        {
            StartPosition = startPos;
        }

        public Knight(string k)
        {
            // TODO: Complete member initialization
            this.Horse = k;
        }

        public override void Draw()
        {
            int startX = StartPosition.X;
            int startY = StartPosition.Y;

            Console.SetCursorPosition(startX, startY);
            Console.Write('k');
        }
    }
}
