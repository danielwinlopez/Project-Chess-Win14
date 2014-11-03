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
            PieceFactory newPiece = new PieceFactory();
            PlayerBlack bPlayer = new PlayerBlack();
            PlayerWhite wPlayer = new PlayerWhite();

            newPiece.NumberOfPieces(newPiece.PlayerList());

            Console.WriteLine();
            

            Console.ReadKey();
            
            Console.WriteLine("              This is Chess\r\n (created by Roje, Tobias and Daniél)");
            Console.Write(" Want to try it out? \r\n \r\n [Y]es / [N]o : ");
            string line = Console.ReadLine();
            
               
            Console.ReadLine();

            while (true) 
            {
                Console.Clear();
                if (line == "Y" || line == "y") 
                {
                    Board GB = new Board(new Position(5, 5), 8);
                    
                    List<Shape> sl = new List<Shape>();
                    sl.Add(GB);

                    GB.Draw();

                    
                 }
                else
                {
                    break;
                }
                Console.ReadLine();
            }


            Console.ReadLine();
        }
    }
}
