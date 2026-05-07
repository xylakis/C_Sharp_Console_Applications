using System;


namespace ConsoleApp1
{ 

	internal class OtherFuncs
	{
        //string playerInput = Console.ReadLine();

        //Console.WriteLine("Your input was: " + playerInput);

        //Console.WriteLine(format: "Value is {0} and {1}.", arg0: 19.8, arg1:65);

        //InputHandler inputHandler = new InputHandler();

        //inputHandler.getNameFromConsole();
        //inputHandler.getCompleteSheetFromConsole();

        //simpleHelloWorld();

        //declarePlayerVariables();

        //testMultipleNamespaces();

        //makeABeep();
        //Console.Write("What is the size of the maps ");
        //string mapSize = Console.ReadLine();

        static void simpleHelloWorld()
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("This is another test");
            Console.Write("My name");
            Console.Write("is");
            Console.Write("Manolis");
            Console.WriteLine('\n');
        }

        static void declarePlayerVariables()
        {
            int playerScore = 115, bonusScore = 55;
            float scoreModifier, distanceToTarget = 105.6f, playerHeight = 175;
            string playerName = "The One and Only, the Mighty Steve", inventoryItem = "Purple gem", latestFoundTreasure = "Steel sword";
            bool playerIsDead = true;

            Console.WriteLine("High score:" + playerIsDead + ", this is quite high!");

            Console.WriteLine($"High score: {playerIsDead} this is quite high!");

            Console.WriteLine($"Distance to target is: {distanceToTarget}");
            Console.WriteLine($"{playerName} has found {latestFoundTreasure} and has aquired from the Dragon's Den {inventoryItem}.");
            Console.Beep();

            int finalScore = playerScore + bonusScore;
            Console.WriteLine("Final score: " + finalScore);

            int numberOfEnemies;
            numberOfEnemies = 10;
            Console.WriteLine("There are " + numberOfEnemies + " enemies.");

        }

        static void testMultipleNamespaces()
        {
            StudioA.Calculator.Message();

            StudioB.Calculator.Message();
        }

        static void makeABeep()
        {

            Console.WriteLine("Press any key to stop...");

            while (!Console.KeyAvailable)
            {
                Console.Beep();      // default beep
                Thread.Sleep(10);  // small delay so it's not insane
            }

            // Consume the key so it doesn't stay in buffer
            Console.ReadKey(true);

            Console.WriteLine("Stopped.");
        }




    }






}


namespace StudioA
{

    internal class Calculator
    {
        // Προσθέστε τη λέξη static για να μπορεί να κληθεί άμεσα
        public static void Message()
        {
            Console.WriteLine("This class belongs to namespace StudioA.");
        }
    }
}
namespace StudioB
{
    class Calculator
    {
        // Προσθέστε τη λέξη static εδώ επίσης
        public static void Message()
        {
            Console.WriteLine("This class belongs to namespace StudioB.");
        }
    }
}
