﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    class Knight : ChessPiece
    {
        public Knight(Position startPos, ChessPieceType.ChessPieceTypes pieceType)
        {
            StartPosition = startPos;
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
