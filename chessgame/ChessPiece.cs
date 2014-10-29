using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    
    public abstract class ChessPiece
    {
        protected int type;
        protected int attackValue;
        protected int defenceValue;
        protected int pieceValue;

        protected Position StartPosition;
        public virtual void Draw()
        {

        }
    }
}
