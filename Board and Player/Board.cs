using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    public class Board
    {
        private PieceFactory pieceFactory;
        private List<ChessPiece> allaPjasorna = new List<ChessPiece>(); 
        public Board()
        {
            pieceFactory = new PieceFactory();
            allaPjasorna.AddRange(pieceFactory.WhitePlayerList());
            allaPjasorna.AddRange(pieceFactory.BlackPlayerList());

            PrintAll();
        }
        private int[,] chessBoard = new int[8, 8];

        public void PrintAll()
        {
            foreach (var item in allaPjasorna)
            {
                Console.WriteLine("X:{0} Y:{1}", 
                    item.Position.X, 
                    item.Position.Y);
            }
        }
        public void PrintBoard(int[,] arr)
        {
            for (int y = 7; y >= 0; y--)
            {
                for (int x = 0; x < 8; x++)
                {
                    int num = arr[x, y];
                    if (num > 0)
                    {
                        Console.Write("[" + (char)1 + "]");
                    }
                    else
                    {
                        Console.Write("[ ]");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
