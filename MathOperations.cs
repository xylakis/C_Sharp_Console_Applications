using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MathOperations
    {

        public void makePlayerStats()
        {

            //Welcome message followed by a blank line.
            Console.WriteLine("Welcome to the (Silly) Score Calculator.");
            Console.WriteLine();
            
            /*
            When we collect input, particularly numbers, the program can crash if the
            user enters input that can’t be properly parsed.
            Assume the user enters meaningful and parse-able input. Bonus Level 3 has
            more information.
            */
            
            //Prompt the user to enter their score.
            Console.Write("Enter your base score: ");
            //Store the player score in a new variable called baseScore.
            int baseScore = int.Parse(Console.ReadLine());
            //Spacing and helpful output.
            Console.WriteLine();
            Console.WriteLine("Here we go … ");
            baseScore++; //increment the score and display
            Console.WriteLine("Incrementing the score by 1: " + baseScore);
            baseScore = baseScore * 3; //multiply the score and display
            Console.WriteLine("Multiplying the score by 3: " + baseScore);
            baseScore += 5; //add to the score and display
            Console.WriteLine("Adding 5 to the score: " + baseScore);
            baseScore /= 2; //divide the score and display
            Console.WriteLine("Dividing the score by 2: " + baseScore);
            baseScore--; //decrement the score and display
            Console.WriteLine("Decrementing the score by 1: " + baseScore);
            //Use Math.Min() to determine which value is smaller − baseScore or 100
            int smallestValue = Math.Min(baseScore, 100);
            Console.WriteLine("Which value is smaller − 100 or " + baseScore + ": " +
            smallestValue);
        }

    }
}
