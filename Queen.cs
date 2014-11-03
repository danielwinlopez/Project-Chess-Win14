﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    class Queen : ChessPiece
    {
        public Queen(Position startPos, ChessPieceType pieceType)
        {
            StartPosition = startPos;
            name = pieceType.ToString();
            PieceType = pieceType;
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
