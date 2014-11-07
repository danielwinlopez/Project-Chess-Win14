using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    public class Move
    {
        public Position GetMove { get; set; }

        public List<Position> QueenMove()
        {
            List<Position> moveList = new List<Position>();

            moveList.Add(new Position(1, 1));  
            moveList.Add(new Position(-1, -1));
            moveList.Add(new Position(0, 1));  
            moveList.Add(new Position(1, 0));  
            moveList.Add(new Position(0, -1)); 
            moveList.Add(new Position(-1, 0)); 
            moveList.Add(new Position(-1, 1));                      
            moveList.Add(new Position(1, -1)); 
                                               
            int antalSteg = 7;
            foreach (var item in moveList)
            {
                List<Position> newList = new List<Position>();

                for (int i = 0; i < antalSteg; i++)
                {
                    var stegX = item.X + GetMove.X;
                    var stegY = item.Y + GetMove.Y;
                    newList.Add(new Position(stegX, stegY));
                }
            }
            return moveList;
        }
        public List<Position> KingMove()
        {
            List<Position> moveList = new List<Position>();

            moveList.Add(new Position(1, 1));  
            moveList.Add(new Position(-1, -1));
            moveList.Add(new Position(0, 1));  
            moveList.Add(new Position(1, 0));  
            moveList.Add(new Position(0, -1)); 
            moveList.Add(new Position(-1, 0)); 
            moveList.Add(new Position(-1, 1)); 
            moveList.Add(new Position(1, -1)); 

            int antalSteg = 1;
            foreach (var item in moveList)
            {
                List<Position> newList = new List<Position>();

                for (int i = 0; i < antalSteg; i++)
                {
                    var stegX = item.X + GetMove.X;
                    var stegY = item.Y + GetMove.Y;
                    newList.Add(new Position(stegX, stegY));
                }
            }
            return moveList;
        }
        public List<Position> BishopMove()
        {
            List<Position> moveList = new List<Position>();

            moveList.Add(new Position(1, 1));  
            moveList.Add(new Position(-1, -1));
            moveList.Add(new Position(-1, 1)); 
            moveList.Add(new Position(1, -1)); 

            int antalSteg = 7;
            foreach (var item in moveList)
            {
                List<Position> newList = new List<Position>();

                for (int i = 0; i < antalSteg; i++)
                {
                    var stegX = item.X + GetMove.X;
                    var stegY = item.Y + GetMove.Y;
                    newList.Add(new Position(stegX, stegY));
                }
            }
            return moveList;
        }
        public List<Position> RookMove()
        {
            List<Position> moveList = new List<Position>();

            moveList.Add(new Position(0, 1));  //Forward
            moveList.Add(new Position(1, 0));  //Right
            moveList.Add(new Position(0, -1)); //Backward
            moveList.Add(new Position(-1, 0)); //Left

            int antalSteg = 7;
            foreach (var item in moveList)
            {
                List<Position> newList = new List<Position>();

                for (int i = 0; i < antalSteg; i++)
                {
                    var stegX = item.X + GetMove.X;
                    var stegY = item.Y + GetMove.Y;
                    newList.Add(new Position(stegX, stegY));
                }
            }
            return moveList;
        }
        public List<Position> PawnMove()
        {
            List<Position> moveList = new List<Position>();
            
            moveList.Add(new Position(0, 1));  //Forward
            
            int antalSteg = 1;
            foreach (var item in moveList)
            {
                List<Position> newList = new List<Position>();

                for (int i = 0; i < antalSteg; i++)
                {
                    var stegX = item.X + GetMove.X;
                    var stegY = item.Y + GetMove.Y;
                    newList.Add(new Position(stegX, stegY));
                }
            }
            return moveList;
        }
        public List<Position> KnightMove()
        {
            List<Position> moveList = new List<Position>();

            moveList.Add(new Position(1, 2));  //Crazy horsemoves
            moveList.Add(new Position(-1, 2));
            moveList.Add(new Position(1, -2));  
            moveList.Add(new Position(-1, -2));  
            moveList.Add(new Position(2, -1)); 
            moveList.Add(new Position(-2, -1)); 
            moveList.Add(new Position(-2, 1)); 
            moveList.Add(new Position(2, 1)); 

            int antalSteg = 1;
            foreach (var item in moveList)
            {
                List<Position> newList = new List<Position>();

                for (int i = 0; i < antalSteg; i++)
                {
                    var stegX = item.X + GetMove.X;
                    var stegY = item.Y + GetMove.Y;
                    newList.Add(new Position(stegX, stegY));
                }
            }
            return moveList;
        }
    }
}