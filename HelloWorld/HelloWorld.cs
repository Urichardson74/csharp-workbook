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

    class Game
    {
        //public Tower[] towers { get; set; }
        public Tower[] towers = new Tower[3];

        public Block B1 = new Block(1);
        public Block B2 = new Block(2);
        public Block B3 = new Block(3);
        public Block B4 = new Block(4);

        public Game()
        {
            this.towers[0] = new Tower("A"); // seems wrong, already allocated space with new...
            this.towers[1] = new Tower("B");
            this.towers[2] = new Tower("C");
            this.towers[0].PushBlock(B4);
            this.towers[0].PushBlock(B3);
            this.towers[0].PushBlock(B2);
            this.towers[0].PushBlock(B3); // this is illegal, just checking
            this.towers[0].PushBlock(B1);
            PrintBoard();

            Console.WriteLine("Done setting up the game, almost ready to play! ");
        }

        public void PrintBoard()
        {
            int w = 0;
            for (int i=0; i<3; i++)
            {
                for (int j=0; j<4; j++)
                {
                    if (towers[i].stack[j] == null) { w = 0; } else { w = towers[i].stack[j].Weight; }
                    Console.WriteLine("Tower {0} position {1} block weight is {2} ", towers[i].tname, j, w);
                }
            }
        }

        public static Tower[] Play()
        {   Tower[] process = new Tower[2];
            Console.WriteLine("Ready to play ... ");
            Console.WriteLine("Which tower do you wish to move a block from ? A, B, or C.");
            string towerChoice = Console.ReadLine();
            Tower start = towers[towerChoice];
            process[0] = start;
            System.Console.ReadLine.WriteLine ("Which tower will you move it to?  A, B, or C.");
            string finalChoice = Console.ReadLine();
            Tower finish = towers[finalChoice];
            process[1] = finish;
            return process;
 


        }

    }

    class Block
    {
        public Block(int weight)
        {
            this.Weight = weight;
        }
        public int Weight { get; private set; }
    }

    class Tower
    {
        //private Block[] stack = new Block[4]; // allocated space for 4 blocks even though there are none to start with, this might not be right...
        public Block[] stack = new Block[4];
        private int stackSize = 0; // keep track of how many blocks are on the stack
        public string tname; // the nmae of the tower, e.g. "A", "B", ...
        public Tower(string n) { tname = n; }
        public void PushBlock(Block b)
        {
            Console.WriteLine("Adding block of weight {0} to tower {1} at position {2} ", b.Weight, tname, stackSize);
            int legal = 1;
            if (stackSize > 0)
            {
                Block topBlock = stack[stackSize - 1];
                if (topBlock.Weight < b.Weight)
                { // It's illegal
                    legal = 0;
                }
            }
            if (legal == 1)
            {
                stack[stackSize] = b;
                stackSize++; // Increment the stack size after adding a block
            }
            else
            {
                Console.WriteLine("Sorry, that move is not legal.");
            }
            
        }

        public void PopBlock()
        {
            if (stackSize > 0)
            {
                stack[stackSize - 1] = null;
                stackSize--;
            }
        }
    }

}