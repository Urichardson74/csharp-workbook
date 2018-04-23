using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {   public string playerchoice { get; set; }
            public string compchoice { get; set; }
            public string results { get; set; }
            public string collectdata { get; set; }
            public int playerscore = 0;
            public int compscore = 0;
            List<string> ListResults = new List <string>
            
            Console.WriteLine("Choose rock paper or scissors:");
            string playerchoice = Console.ReadLine().ToLower();
            Console.WriteLine(CompareHands(playerchoice, compchoice));

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }
        
        public void computerChoice
        {
            Random randomNumber = new Random ();
            int x = randomNumber.next(0,3);
            if (x == 0) 
            {
                compchoice = "rock";

            }
            if (x== 1)
            {
                compchoice = "paper"
            }
            if (x== 2)
            {
                compchoice = "scissors"
            }
        }
        public static string CompareHands(string playerchoice, string compchoice)
        {
            // Your code here
            return playerchoice + ' ' + compchoice;
        }
    }
}
