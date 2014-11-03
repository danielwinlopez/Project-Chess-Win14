using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    class PlayerWhite : Player
    {
        public PlayerWhite() : base(TeamColor.Color.White)
        {
        }

        public List<string> showPieces()
        {
            List<string> test = new List<string>();

            for (int i = 0; i < 6; i++)
            {
                test.Add(((ChessPieceType.ChessPieceTypes)i).ToString());

            }
            return test;
        }
    }
}
