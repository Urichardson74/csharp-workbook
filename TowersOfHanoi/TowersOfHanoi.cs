﻿using System;
using System.Collections.Generic;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
        }
    }

    class Game 
    {
        public Tower[] towers {get; set;}

        public Game()
        {
            this.towers = new Dict
        }
    }

    class Block
    {
        public Block (int weight)
        {
            this.Weight = weight;
        }
        public int Weight{ get; private set; }
    }

    class Tower
    {
        private Block[] blocks;
        public void PushBlocks()
        {

        }

        public void PopBlocks()
        {
            
        }
    }


}
