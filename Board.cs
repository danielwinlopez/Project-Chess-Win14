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
        public  void Draw()
        {
            int startX = StartPosition.X;
            int startY = StartPosition.Y;
            Console.WriteLine(" \r\n \r\n \r\n \r\n ");

            for (int y = startY; y < startY + Length; y++)
            {
                
                for (int x = startX; x < startX + Length; x++)
                {
                    if (x == startX)
                    {
                        Console.SetCursorPosition(startX, Console.CursorTop);
                    }
                    Console.Write(" [ ]");
                }
                Console.WriteLine(" \r\n ");
            }
        }
    }
}
