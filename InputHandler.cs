using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class InputHandler
    {

        public void getNameFromConsole()
        {
            Console.Write("Enter your name: ");
            string playerFirstName = Console.ReadLine();
            Console.WriteLine("Fantastic! We are glad you joined us " + playerFirstName);
        }

        //reading string from the console and converting this (parsing) to other data types
        public void getAgeFromConsole()
        {
            Console.Write("Greetings brave adventurer! What is your age: ");
            int playerAge = int.Parse(Console.ReadLine());
            Console.Write("Wonderful. " + playerAge + " is a fine age indeed.");
        }

        public void getCompleteSheetFromConsole()
        {
            //Prompt the player for their name
            Console.Write("Hello player! What is your first name: ");
            //Collect and store the player name (as a string)
            string playerName = Console.ReadLine();
            
            //Prompt the player for their age
            Console.Write("And, what is your age: ");
            //Collect and store the player age (as an int)
            int playerAge = int.Parse(Console.ReadLine());
            
            //Prompt the player for their game playing time
            Console.Write("How many hours of video games do you play per week: ");
            //Collect and store the player game time (as a float)
            float playerGameTime = float.Parse(Console.ReadLine());
            
            //Output a blank line (to make the output nicer)
            Console.WriteLine();

            //Output all of variable that were input by the player
            Console.WriteLine("Player stats:");
            Console.WriteLine("Player name: " + playerName); //output name
            Console.WriteLine("Player age: " + playerAge); //output age
            Console.WriteLine("Player Game Time (per week): " + playerGameTime);
            //output game time
        }

    }
}
