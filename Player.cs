using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    class Player
    {
        private string name;

        // Property to keep track on the amount of pieces the player got left
        public byte PiecesAmount { get; set; }
    }
}
