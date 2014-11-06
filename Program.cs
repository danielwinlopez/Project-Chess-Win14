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
            Board boards = new Board();
            Position white = new Position(6,6);
            PieceFactory newPiece = new PieceFactory();
            Player wPlayer = new Player(Color.White);
            Player bPlayer = new Player(Color.Black);
             int [,] boardarr = new int[8,8];

          

            boards.PrintBoard(boardarr);

           
            

            //List<string> blackplayer = newPiece.BlackPlayerList(); 
            //blackplayer.RemoveAt(3);
            
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
