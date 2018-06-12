using System;
using System.Collections.Generic;
using System.Linq;

namespace Chequers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Game.Start();
        }
    }
    class Checker
    {
        public string Symbol { get; set; }
        public int[] Position { get; set; }
        public string Color { get; set; }
        public Checker(string color, int[] position)
        {
            this.Color = color;
            if (this.Color == "black")
            {
                this.Symbol = "\u25CE";
            }
            if (this.Color == "white")
            {
                this.Symbol = "\u25C9";
            }
            this.Position = position;
        }
    }
    class Board
    {
        public string[][] Grid { get; set; }
        public List<Checker> Checkers { get; set; }

        private static int[][] whitePositions = new int[][]
        {
            new int[] {0,1}, new int[] {0,3}, new int[] {0,5}, new int[] {0,7},
            new int[] {1,0}, new int[] {1,2}, new int[] {1,4}, new int[] {1,6},
            new int[] {2,1}, new int[] {2,3}, new int[] {2,5}, new int[] {2,7}
        };
        private static int[][] blackPositions = new int[][]
        {
            new int[] {5,0}, new int[] {5,2}, new int[] {5,4}, new int[] {5,6},
            new int[] {6,1}, new int[] {6,3}, new int[] {6,5}, new int[] {6,7},
            new int[] {7,0}, new int[] {7,2}, new int[] {7,4}, new int[] {7,6}
        };
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
                new string[] {" ", " ", " ", " ", " ", " ", " ", " "}
            };
        }
        public void DrawBoard()
        {
            PlaceCheckers();
            System.Console.WriteLine("  0 1 2 3 4 5 6 7");
            for (int i = 0; i < 8; i++)
            {
                System.Console.WriteLine(i + " " + String.Join(" ", this.Grid[i]));
            }
        }
        public void PlaceCheckers()
        {
            foreach (var checker in Checkers)
            {
                this.Grid[checker.Position[0]][checker.Position[1]] = checker.Symbol;
            }
        }
        public void GenerateCheckers()
        {
            for (int i = 0; i < 12; i++)
            {
                Checker black = new Checker("black", blackPositions[i]);
                Checker white = new Checker("white", whitePositions[i]);
                Checkers.Add(black);
                Checkers.Add(white);
            }
        }
        public Checker SelectChecker()
        {
            System.Console.WriteLine("Enter row number to select:");
            int row = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter column number to select:");
            int column = Convert.ToInt32(Console.ReadLine());
            return Checkers.Find(x => x.Position.SequenceEqual(new List<int> { row, column }));
        }
        public void MoveChecker(Checker checker)
        {
            System.Console.WriteLine("Enter row number to move:");
            int row = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter column number to move:");
            int column = Convert.ToInt32(Console.ReadLine());
            checker.Position[0] = row;
            checker.Position[1] = column;
        }
        public void RemoveChecker(int oldRow, int oldCol, int newRow, int newCol)
        {
            if (Math.Abs(newRow - oldRow) > 1)
            {
                int row = (oldRow + newRow) / 2;
                int col = (oldCol + newCol) / 2;
                Checker checker = Checkers.Find(x => x.Position.SequenceEqual(new List<int> { row, col}));
                Checkers.Remove(checker);
            }
        }
        public bool CheckForWin()
        {
            return Checkers.All(x => x.Color == "white") || !Checkers.Exists(x => x.Color == "white");
        }
        public Board()
        {
            this.CreateBoard();
            this.Checkers = new List<Checker>();
        }
    }
    class Game
    {
        public static void Start()
        {
            Board board = new Board();
            board.GenerateCheckers();
            board.DrawBoard();
            while (!board.CheckForWin())
            {
                Checker temp = board.SelectChecker();
                int oldRow = temp.Position[0];
                int oldCol = temp.Position[1];
                board.MoveChecker(temp);
                int newRow = temp.Position[0];
                int newCol = temp.Position[1];
                board.RemoveChecker(oldRow, oldCol, newRow, newCol);
                board.CreateBoard();
                board.DrawBoard();
                if (board.CheckForWin())
                {
                    System.Console.WriteLine("Game Over!");
                    return;
                }
            }
        }
    }
}


