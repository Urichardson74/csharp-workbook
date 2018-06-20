using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkers
{
    class Program
    {
        static void Main(string[] args)
        {
            Game newGame = new Game();
            Console.WriteLine("Hi");
           
        }
    }

    public class Checker
    {
        public string Symbol  { get; set; }
        public int[] Position  { get; set; }
        public string Color { get; set; }
        
        public Checker(string color, int[] position)
        {
            int circleId;
            if (color == "white") 
            {
                circleId= int.Parse("25CB", System.Globalization.NumberStyles.HexNumber);
            }
            else if (color == "black")
            {
                circleId= int.Parse("25CF", System.Globalization.NumberStyles.HexNumber);
            }
        
            else 
            {
            circleId= int.Parse("25A9", System.Globalization.NumberStyles.HexNumber);
            }
            
           
            
            this.Symbol = char.ConvertFromUtf32(circleId);    
            this.Position = position;
            
        }
    }

    public class Board
    {
        public string[][] Grid  { get; set; }
        public List<Checker> Checkers { get; set; }
        
        public Board()
        {
            this.Checkers = new List<Checker>();
            this.CreateBoard();
     
            return;
        }
        
        public void CreateBoard()
        {
            this.Grid = new string[][] 
            {
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "},
            };
            return;
        }
        
        public void GenerateCheckers()
        {
             int[][] whitePositions = new int[][] 
            {
                //creating checkers 
                new int[] { 0, 1 }, new int[] { 0, 3 }, new int[] { 0, 5 }, new int[] { 0, 7 },
                new int[] { 1, 0 }, new int[] { 1, 2 }, new int[] { 1, 4 }, new int[] { 1, 6 },
                new int[] { 2, 1 }, new int[] { 2, 3 }, new int[] { 2, 5 }, new int[] { 2, 7 }
            };

            int[][] blackPositions = new int[][] 
            {
                new int[] { 5, 0 }, new int[] { 5, 2 }, new int[] { 5, 4 }, new int[] { 5, 6 },
                new int[] { 6, 1 }, new int[] { 6, 3 }, new int[] { 6, 5 }, new int[] { 6, 7 },
                new int[] { 7, 0 }, new int[] { 7, 2 }, new int[] { 7, 4 }, new int[] { 7, 6 }
            };

                int[][] squarePositions = new int[][] 
            {   
                //creating squares of checkerboard
                new int[] { 0, 0 }, new int[] { 0, 2 }, new int[] { 0, 4 }, new int[] { 0, 6 },
                new int[] { 1, 1 }, new int[] { 1, 3 }, new int[] { 1, 5 }, new int[] { 1, 7 },
                new int[] { 2, 0 }, new int[] { 2, 2 }, new int[] { 2, 4 }, new int[] { 2, 6 },
                new int[] { 3, 1 }, new int[] { 3, 3 }, new int[] { 3, 5 }, new int[] { 3, 7 },
                new int[] { 4, 0 }, new int[] { 4, 2 }, new int[] { 4, 4 }, new int[] { 4, 6 },
                new int[] { 5, 1 }, new int[] { 5, 3 }, new int[] { 5, 5 }, new int[] { 5, 7 },
                new int[] { 6, 0 }, new int[] { 6, 2 }, new int[] { 6, 4 }, new int[] { 6, 6 },
                new int[] { 7, 1 }, new int[] { 7, 3 }, new int[] { 7, 5 }, new int[] { 7, 7 }
            };

             for (int i = 0; i < 12; i++)
            {
                Checker white = new Checker("white", whitePositions[i]);
                Checker black = new Checker("black", blackPositions[i]);
                
                Checkers.Add(white);
                Checkers.Add(black);
               
            }

            for (int i = 0; i < 32; i++)
            {
                Checker square = new Checker("square", squarePositions[i]); 
                Checkers.Add(square);
            }
            return;
        }
        
        public void PlaceCheckers()
        {
            foreach (var checker in Checkers)
            {
                this.Grid[checker.Position[0]] [checker.Position[1]] = checker.Symbol;
            }
            return;
        }
        
        public void DrawBoard()
        {   
            CreateBoard();
            PlaceCheckers();
            Console.WriteLine("  0 1 2 3 4 5 6 7");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(i + " " + String.Join(" ", this.Grid[i]));
            }
            return;
        }
        
        public Checker SelectChecker(int row, int column)
        {
            return Checkers.Find(x => x.Position.SequenceEqual(new List<int> { row, column }));
        }
        
        public void RemoveChecker(Checker checker)
        {
            this.Checkers.Remove(checker);
            return;
        }
        
        public bool CheckForWin()
        {
            
        
            if (Checkers.All(checker => checker.Color == "white"))
            {
                Console.WriteLine("White wins!");
                return true;
            }
            else if (Checkers.Exists(checker => checker.Color == "white"))
            {
                Console.WriteLine("Black wins!");
                return true;
            }
            return false;
        }
        
    }

    class Game
    {
        public Game()
        {
            Board board = new Board();
            board.GenerateCheckers();
            board.DrawBoard();

            // need to keep track of whose go it is, so it always goes b, w, b etc.
            string whoseTurn = "black";
            
            while (!board.CheckForWin())
            
            {
                bool validMove = false;
                Console.WriteLine("Select checker row:");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Select checker column:");
                int col = Convert.ToInt32(Console.ReadLine());

                Checker checker = board.SelectChecker(row, col);

                // should now check if the checker exists and is the right color e.g. 
                //if (!(checker == null) && (whoseTurn == checker.Color)
                //{}

                Console.WriteLine("Please move checker to an empty space.");
                Console.WriteLine("Move to which row:");
                int newRow = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Move to which Column:");
                int newCol = Convert.ToInt32(Console.ReadLine());

                // First we need to check if it's a valid move, i.e. it's either 1 diagonal away from the existing position, or it's 2 diagonals jumping over an opponent checker...

                Checker newPosChecker = board.SelectChecker(newRow, newCol);
                if (newPosChecker == null) // there's nothing there yet, so far so good
                {
                    // Is it one diagonal apart?
                    if (Math.Abs((row - newRow) * (col - newCol)) == 1) // it is exactly 1 row and 1 column apart?
                    {
                        validMove = true;
                        //checker.Position = new int[] { newRow, newCol }; // SEM - moved to below
                    }

                    // or is it exactly 2 row and 2 columns apart, with a checker in between?
                    else
                    {
                        if ((Math.Abs(row - newRow) == 2) && (Math.Abs(col - newCol) == 2)) // exactly 2 squares away, so far so good
                        {
                            // now to check whether something got jumped over ...?
                            int deadCheckerRow = (row + newRow) / 2;
                            int deadCheckerCol = (col + newCol) / 2;
                            Checker deadChecker = board.SelectChecker(deadCheckerRow, deadCheckerCol);
                            if (!(deadChecker == null)) // and do we need to check the color of it? Can you jump over your own checkers?
                            {
                                validMove = true;
                                // remove the dead checker
                                board.RemoveChecker(deadChecker);
                                board.Grid[deadCheckerRow][deadCheckerCol] = " "; // the checker is removed, the grid position needs to be cleared
                            }
                        }
                    }
                }
                if (validMove == true)
                {
                    checker.Position = new int[] { newRow, newCol };
                    board.Grid[row][col] = " "; // the checker is moved, the grid position needs to be cleared
                    whoseTurn = SwitchTurns(whoseTurn);
                }
                else
                { 
                    Console.WriteLine("Not a legal move");
                    Console.WriteLine("Enter any key");
                    Console.ReadLine();
                }
                board.DrawBoard();
            }
        }

        string SwitchTurns(string whoseTurn) // Switch colors: if it's black's turn - returns white, otherwise returns black.
        {
            if (whoseTurn == "black")
            { return "white"; }
            return "black";
        }
    }
}