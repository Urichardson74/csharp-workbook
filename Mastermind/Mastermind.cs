using System;
using System.Collections.Generic;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            for ( int turns = 0; turns < 10; turns++)
            {
                Console.WriteLine("Choose Four Letters "); 
                string letters =Console.ReadLine();
                string[] letterSplit = letters.Split(' ');
                Ball[] balls = new Ball[4];
                for (int i = 0; i < 4; i++)
                {
                    balls[i] = new Ball (letterSplit[i]);
              
                }
                Row row1 = new Row(balls);
                game.AddRow(row);
                Console.WriteLine(game.Rows)

            }
            Console.WriteLine("Stop");

        }

           
    }
       





    class Game 
    {
        private List <Row> rows = new List<Row>();

        public Game () 
        {

        }

        public void AddRow(Row row)
        {
           this.rows.Add(row);
        }
        public string Rows
        {
                get
            {
                foreach (var row in this.rows)
                {
                    Console.WriteLine(row.Balls);
                }
                return "You have 3 tries left.";
            }   
        }

       
    }

    class Ball
    {
        public string Letter { get; private set; }
        public Ball(string letter)
        {
            this.Letter = letter;
        }
    }

    class Row
    {
        public Ball[] balls = new Ball [4];
        
        public Row (Ball[] balls)
        {
            this.balls = balls;
        }
        public string Balls
        {
            get
            {
                foreach (var ball in this.balls)
                {
                    Console.Write(ball.Letter);
                }
                return " 1-1";
            }
          
        }
    }



}

