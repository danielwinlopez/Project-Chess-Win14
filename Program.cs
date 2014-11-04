using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{    
    class Program
    {
        static void Main(string[] args)
        {
            Position white = new Position(6,6);
            PieceFactory newPiece = new PieceFactory();
            Player wPlayer = new Player(Color.White);
            Player bPlayer = new Player(Color.Black);
            Board board = new Board(new Position(8,8),8);
            Position newPosition = new Position(0,0);

            Console.WriteLine("BLACK PLAYER: \r\n-------------");
            bPlayer.ShowPieces();
            Console.WriteLine();
            Console.WriteLine("WHITE PLAYER: \r\n-------------");
            wPlayer.ShowPieces();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
