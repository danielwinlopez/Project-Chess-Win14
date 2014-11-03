using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    public class King : ChessPiece
    {
        private string Kung;

        public King(Position startPos)
        {
            StartPosition = startPos;
        }

        public King(string K)
        {
            // TODO: Complete member initialization
            this.Kung = K;
        }

        public override void Draw()
        {
            int startX = StartPosition.X;
            int startY = StartPosition.Y;

            Console.SetCursorPosition(startX, startY);
            Console.Write('K');
        }
    }
}
