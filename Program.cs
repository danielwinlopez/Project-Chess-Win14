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
            Console.WriteLine("              This is Chess\r\n (created by Roje, Tobias and Daniél)");
            Console.WriteLine(" Want to try it out? \r\n \r\n [Y]es / [N]o");
            string line = Console.ReadLine();
            PlayerBlack bPlayer = new PlayerBlack("Black Player");
            PlayerWhite wPlayer = new PlayerWhite("White Player");


            bPlayer.TimesInList(bPlayer.showPieces());

           
            
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
