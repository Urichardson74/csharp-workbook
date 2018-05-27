using System;
using System.Collections.Generic;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            Game g = new Game();
            g.Play();
        }
    }

    public class Game
    {
        public static Dictionary<string, Tower> Towers { get; set; }
        //public Dictionary<string, Tower> Towers { get; set; }
        public int numBlocks = 4;

        public Block gameBlock1;
        public Block gameBlock2;
        public Block gameBlock3;
        public Block gameBlock4;
        
        public Game()
        {
            //Dictionary<string, Tower> Towers = new Dictionary<string, Tower>();
            Towers = new Dictionary<string, Tower>();

            Towers.Add("A", new Tower("A"));
            Towers.Add("B", new Tower("B"));
            Towers.Add("C", new Tower("C"));

            gameBlock1 = new Block(1);
            gameBlock2 = new Block(2);
            gameBlock3 = new Block(3);
            gameBlock4 = new Block(4);

            Towers["A"].PushBlock(gameBlock4);
            Towers["A"].PushBlock(gameBlock3);
            Towers["A"].PushBlock(gameBlock2);
            Towers["A"].PushBlock(gameBlock3); // this is illegal, just checking
            Towers["A"].PushBlock(gameBlock1);

            foreach (var key in Towers.Keys)
            {
                Console.WriteLine("Tower: " + key);
                foreach (Block b in Towers[key].Blocks)
                {
                    Console.WriteLine(" weight: {0} ", b.Weight);
                }
                Console.WriteLine("");
            }
            PrintBoard(); // not sure why this fails

            Console.WriteLine("Done setting up the game, almost ready to play! ");
        }

        public void PrintBoard()
        {
            foreach (var key in Game.Towers.Keys) // returns NullReferenceException
            {
                Console.WriteLine("Tower: " + key);
                foreach (Block b in Towers[key].Blocks)
                {
                    Console.WriteLine(" weight: {0} ", b.Weight);
                }
                Console.WriteLine("");
            }
        }

        public int MovePiece(string popOff, string pushOn)
        { // returns 1 if the game is won, otherwise 0
            if (IsLegal(popOff, pushOn) == true)
            {
                Tower fromTower = Towers[popOff];
                Tower toTower = Towers[pushOn];

                toTower.PushBlock(fromTower.PopBlock());
                if (toTower.Blocks.Count == numBlocks)
                { return 1; }
            }
            return 0;
        }

        public bool IsLegal(string popOff, string pushOn)
        {
            bool legal = false;
            if ((Towers.ContainsKey(popOff) == false) || (Towers.ContainsKey(pushOn) == false))
            {
                Console.WriteLine("Invalid tower");
            }
            else
            {
                Tower fromTower = Towers[popOff]; // returns NullReferenceException
                Tower toTower = Towers[pushOn];
                if (fromTower.Blocks.Count > 0)
                { // so far so good, there's a block on the from tower
                    Block fromTopBlock = fromTower.Blocks.Peek();
                    if (toTower.Blocks.Count > 0)
                    { // check the block isn't too heavy
                        Block toTopBlock = toTower.Blocks.Peek();
                        if (fromTopBlock.Weight < toTopBlock.Weight)
                        { // It's legal
                            legal = true;
                        }
                        else
                        {
                            Console.WriteLine("The block is too heavy");
                        }
                    }
                    else
                    { // It's legal
                        legal = true;
                    }
                }
                else
                {
                    Console.WriteLine("The tower has no block to move");
                }
            }
            return legal;
        }

        public void Play()
        {
            Console.WriteLine("Ready to play ... ");
            int finished = 0;
            int won = 0;
            //Tower[] process = new Tower[2];
            //Tower fromTower;
            //Tower toTower;
            string fromChoice, toChoice;

            while (finished == 0)
            {
                Console.WriteLine("Which tower do you wish to move a block from ? A, B, or C, or P to print, Q to quit.");
                fromChoice = Console.ReadLine();
                if (fromChoice == "Q")
                { finished = 1; }
                else
                if (fromChoice == "P")
                {
                    PrintBoard();
                }
                else
                {
                    //fromTower = towers[towerChoice];
                    //process[0] = fromTower;
                    Console.WriteLine("Which tower will you move it to?  A, B, or C, or Q to quit.");
                    toChoice = Console.ReadLine();
                    if (toChoice == "Q") { finished = 1; }
                    else
                    {
                        //toTower = towers[towerChoice];
                        //process[1] = toTower;
                        won = MovePiece(fromChoice, toChoice);
                        if (won == 1) { finished = 1; }
                    }
                }
            }
            if (won == 1)
            {
                Console.WriteLine("Congratulations!");
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }
        }
    }

    public class Block
    {
        public Block(int w)
        {
            this.Weight = w;
        }
        public int Weight { get; private set; }
    }

    public class Tower
    {
    //private Block[] stack = new Block[4]; // allocated space for 4 blocks even though there are none to start with, this might not be right...
    //public Block[] stack = new Block[4];
    public Stack<Block> Blocks { get; set; }
    public string name { get; private set; }
    public Tower(string n)
    {
        name = n;
        Blocks = new Stack<Block>();
    }

    public void PushBlock(Block b)
        {
            Console.WriteLine("Adding block of weight {0} to tower at position {1} ", b.Weight, Blocks.Count+1);
            
            int legal = 1;
            
            if (Blocks.Count > 0)
            {
                Block topBlock = Blocks.Peek();
                if (topBlock.Weight < b.Weight)
                { // It's illegal
                    legal = 0;
                }
            }
            
            if (legal == 1)
            {
                this.Blocks.Push(b);
                //stack[stackSize] = b;
                //stackSize++; // Increment the stack size after adding a block
            }
            else
            {
                Console.WriteLine("Sorry, that move is not legal.");
            }
            
        }

        public Block PopBlock()
        {
            if (Blocks.Count > 0)
            {
                return this.Blocks.Pop();
                //stack[stackSize - 1] = null;
                //stackSize--;
            }
            else
            {
                Console.WriteLine("Sorry, there is nothing to remove.");
                return null;
            }
        }
    }

}
