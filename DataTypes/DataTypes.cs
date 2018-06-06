
using System;
using System.Threading;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
              //Variables//
            string torch = "";
            string flint = "";
            string spider ="";
            string fight ="";
            string light ="";
            
           
            //Start program//
           Console.WriteLine("Welcome to the Tunnel of Terror!");
           Thread.Sleep(3000); 
           Console.WriteLine();
           Console.WriteLine("You enter a dark tunnel out of curiosity. With the faint light from the entrace you see a small glimmer from an object on the floor do you pick it up? y or n?");
           //flint choice//
           flint = Console.ReadLine();
           if (flint == "y")
           {
               Console.WriteLine("You reach down and find a piece of flint. You hold onto this as it could possibly used as a weapon later.");
           }
            else if (flint == "n")
            {
                Console.WriteLine("Not wanting to touch something you can't see clearly you move on.");
            }
          Thread.Sleep(1500);
          Console.WriteLine("As you move further your foot touches an object on the floor do you pick it up? y or n?");
           torch = Console.ReadLine();
           // torch choice//
           if (torch == "y")
           {
               Console.WriteLine("You reach down and pick up the object, as you feel the object you realize it is a torch. Lit or not you can use this as a weapon.");
           }
            else if (torch == "n")
            {
                Console.WriteLine("Not wanting to touch something you can't see clearly you move on.");
            }
            Thread.Sleep(1000);
                //flint + torch = light//
               if (torch == "y" & flint == "y")
           {
               Console.WriteLine();
               Console.WriteLine("You strike the flint off another hard stone and manage to light the torch.");
               light = "y";
           }
            else if (torch == "n" || flint == "n")
            {   
                Console.WriteLine();
                Console.WriteLine("You stumble forward into the darkness.");
            }
            //spider encounter//
            Thread.Sleep (1500);
            Console.WriteLine();		
            Console.WriteLine("As you continue into the cavern and you see a faint glowing object at the edge of the chamber.");
            Console.WriteLine();
            Thread.Sleep (1500);
            Console.WriteLine("Do you approach the glowing object? [y/n]: ");
            spider = Console.ReadLine();

            if (spider == "y")
                
            {
                Console.WriteLine();
                Thread.Sleep (1500);
                Console.WriteLine("As you move closer you realize that the glowing object is an enourmous eye.");
                Console.WriteLine();
                Thread.Sleep (1500);
                Console.WriteLine("You are now face to face with a gigantic spider!");
            }
            
            else if (spider == "n")
            {
                Console.WriteLine();
                Console.WriteLine("You try to slip by the object without disturbing it, as you slip by you notice the object starts to move!");
                Console.WriteLine();
                Thread.Sleep (1500);
                Console.WriteLine("The glowing object turns to you! You realize you're staring into the eye of a gigantic spider!");
                Thread.Sleep (1500);
            }

            Console.WriteLine();
            Thread.Sleep (1000);
            Console.WriteLine("Your first instinct is to run for yor life, do you turn and fight the spider instead?  y/n");
            fight = Console.ReadLine();
            //fight is unavoidable//
            //with lit torch odds are better//
            if (fight == "y" & light =="y")
            {
                Random r = new Random();
                int number = r.Next(3, 10);

                if (number < 4)
                {
                    Console.WriteLine("You thrust feebly at the spider but miss and stumble forward. The Spider pounces and sinks it's fangs into your back, you lay paralzyed and await death.");
                    Console.WriteLine();
                }
                else if (number < 7)
                {   Thread.Sleep (1500);
                    Console.WriteLine("You fight the spider valiantly but you just don't have a good enough weapon.  Eventually the spider wears you down and grabs you, it then begins wrapping you in it's web....");
                    Console.WriteLine();
                }
                else if (number < 9)
                {   Thread.Sleep (1500);
                    Console.WriteLine("You get a clean strike at the spiders eye you hear a nice sizzle the spider shrieks and runs away!");
                    Console.WriteLine();
                }   
                else 
                {   Thread.Sleep (1500);
                    Console.WriteLine("You get a perfect strike and puncture the spider's huge eye, the flame from the torch lights the hairs surrounding the spider's eye. Soon the flame spreads over the whole spider. As the spider quivers you look down and in the firlight you see the shimmer of gold.  There is a nice pile of loot that the spider dropped from it's previous victims. Your pockets are filled with gold and jewels as you escape the Tunnel of Terror!");
                    Console.WriteLine();
                }
                   
            }
            //With no torch or unlit torch more difficult to win//
            else if (fight == "y" || light == "n")
            {
                Random r = new Random();
                int number = r.Next(1, 9);

                if (number < 4)
                {   Thread.Sleep (1500);
                    Console.WriteLine("You thrust your weapon feebly in the dark at the spider but miss and stumble forward. The Spider pounces and sinks it's fangs into your back, you lay paralzyed and await death.");
                    Console.WriteLine();
                }
                else if (number < 7)
                {   Thread.Sleep (1500);
                    Console.WriteLine("You fight the spider valiantly but you just don't have a good enough weapon.  Eventually the spider wears you down and grabs you, it then begins wrapping you in it's web....");
                    Console.WriteLine();
                }      
         
                else if (number < 9)
                {   Thread.Sleep (1500);
                    Console.WriteLine("You get a clean strike at the spiders eye and it shrieks and runs away!");
                    Console.WriteLine();
                }
                    
                else 
                {   Thread.Sleep (1500);
                    Console.WriteLine("You get a perfect strike and puncture the spider's huge eye, you push further and drive your weapon into his brains. As the spider quivers in the dark you slip back out the way you came just happy to escape the Tunnel of Terror alive!");
                    Console.WriteLine();
                }
                   
                   
            }
            //running is certain death//
            else if (fight == "n")
            {
                Console.WriteLine();
                Console.WriteLine("The spider is quicker than you and jumps on your back. You feel its fangs sink deep into you as you slowly die in agoninizing pain.");
                Console.WriteLine();
               
            }
            




        }
    }
}