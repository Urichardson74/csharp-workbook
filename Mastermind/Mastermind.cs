using System;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Ball
    {
        public string Letter { get; private set; }
        public Ball(string letter)
        {
            this Letter = letter;
        }
    }



}

