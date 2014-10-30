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
        public override void Draw()
        {
            int startX = StartPosition.X;
            int startY = StartPosition.Y;
            
            for (int y = startY; y < startY + Length; y++)
            {
                Console.SetCursorPosition(startX, y);
                Console.ForegroundColor = ConsoleColor.White;
                
                for (int x = startX; x < startX + Length; x++)
                {
                    
                    Console.Write("[]");
                    
                }
                Console.Write("[]");
            }
        }
    }
}
