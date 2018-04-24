using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()

        {
            bool playAgain = true;
            while(playAgain)
            {
                Console.WriteLine("Enter hand 1:");
                string hand1 = Console.ReadLine().ToLower();
                string hand2 = "";
                Console.WriteLine(CompareHands(hand1, hand2));
                // int playerscore = 0;
                // int compscore = 0;
                // Console.WriteLine("Computur Score:" + (compscore));
                // Console.Writeine("Player Score:" +(playerscore));
                Random compchoice = new Random();
                int x = compchoice.Next(0,3);
                
                
                if (x == 0)
                {

                    hand2 = "Rock";
                }
                if (x == 1)
                {
           
                    hand2 = "Paper";
                }
                if (x == 2)
                {
             
                    hand2 = "Scissors";
                }


                Console.WriteLine("Play Again? [yes or no]");
                string answer = "";
                answer = Console.ReadLine();
                if (answer == "yes")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
           
            // leave this command at the end so your program does not close automatically
            Console.ReadLine();

        }
        }
        
        public static string CompareHands(string hand1, string hand2)
        {
    

            if (hand1 == hand2)
            {
                Console.WriteLine("It's a tie.");
            }

            else if (hand1 == "rock")
            {
                 if (hand2 == "paper")
                {
                    Console.WriteLine("Computer chose paper computer wins.");
                    // compscore ++;
                }
                else 
                {
                    Console.WriteLine("Computer chose scissors you win!");
                    // playerscore ++;
                }
            }
            else if (hand1 == "paper")
            {
                if (hand2 == "rock")
                {
                    Console.WriteLine("Computer chose rock you win!");
                    // playerscore ++;
                }
                else 
                {
                    Console.WriteLine("Computer chose scissors computer wins.");
                    // compscore ++;
                }
            }
            else if (hand1 == "scissors")
            {  
                if (hand2 == "rock")
                {
                    Console.WriteLine("Computer chose rock you lose.");
                    // compscore++;
                }
                else
                {
                    Console.WriteLine("Computer chose paper you win.");
                    // playerscore++;
                }
            
            }
            // return compscore;
            // return playerscore;
            return hand1 + ' ' + hand2;

        }
    }
}
