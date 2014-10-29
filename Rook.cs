﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    class Rook : ChessPiece
    {
        public Rook(Position StartPos)
        {
            StartPosition = StartPos;
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