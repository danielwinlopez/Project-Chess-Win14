using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    public class Board : Shape
    {
        public int Length;

        public Board(Position StartPos, int Length)
        {
            StartPosition = StartPos;
            this.Length = Length;
        }

        public void Draw()
        {
 
            



        }
    }
}
