using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    class PlayerWhite : Player
    {
        PieceFactory newPieces = new PieceFactory();

        public PlayerWhite() : base(TeamColor.Color.White)
        {
        }

        public void showPieces()
        {
              newPieces.NumberOfPieces(newPieces.PlayerList());
        }
    }
}
