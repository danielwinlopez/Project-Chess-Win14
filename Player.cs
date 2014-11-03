using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    public class Player
    {


        private string teamColor;
        List<string> pieces = new List<string>();


        private string name;

        // Property to keep track on the amount of pieces the player got left
<<<<<<< HEAD

=======
>>>>>>> origin/master
        public byte PiecesAmount { get; set; }

        public Player(TeamColor.Color color)
        {
            var teamColor = color;
        }



        public List<string> ChessPieceList(List< string> pieceType)
        {
            
            pieces = new List<string>();
           

            foreach (var item in pieceType)
            {
                pieces.Add(item);
            }

            return pieces;
        }



       
    }
}
