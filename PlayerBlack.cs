﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    class PlayerBlack : Player
    {


        public PlayerBlack(string playerBlack) : base(playerBlack)
        {
        }

        public List<string> showPieces()
        {
            List<string> test = new List<string>();

            for (int i = 0; i < 6; i++)
            {
                test.Add(((ChessPiece.ChessPieceType) i).ToString());
                
            }
            return test;
        }

    }
}
