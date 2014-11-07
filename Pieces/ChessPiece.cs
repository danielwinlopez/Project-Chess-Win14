using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    public abstract class ChessPiece
    {
        internal string name;
 
        //internal bool Selected; //TODO: only if we have time
        //internal bool Moved; //TODO: only if we have time(not important)     
        internal ChessPieceType PieceType;
        public static ChessPiece ChessPiecesPiece { get; set; }
        public int AttackValue { get; set; } 
        public int DefenceValue { get; set; } 
        public int PieceValue { get; set; }
        public int PieceActionValue { get; set; }
        public Position Position { get; set; }
        public List<Position> GetMove { get; set; } 
        
        
        
        public virtual void Draw()
        {

        }
        public ChessPiece()
        {
            
        }
    }
}
    

