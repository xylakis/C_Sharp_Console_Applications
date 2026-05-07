namespace ConsoleApp1
{
    // The keyword internal prevents the class/code to be accessed directly 
    // by another program. 
    internal class Program
    {

        static public int mapSize = 10;

        static public int playerPosX = (int)mapSize/2;
        static public int playerPosY = (int)mapSize/2;

        static public int playerHealth = 85;
        static public string dungeonName = "The swamps";
        static public int dungeonLevel = 1;
        static public int playerExp = 0;
        static public string playerName = " "; 



        static void Main(string[] args)
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

            char[,]  myMap = createAMap(mapSize);

            myMap = updateMyMap(myMap);
            drawMyMap(myMap);
            drawMyStats();

            makeAMove(myMap);
            

            //randomEncounters();

        }

        static void randomEncounters()
        {
            int d20 = 0;
            double dMultiplier = 0;
            int numberOfEncounters = 0;
            int outcome = 0;
            string decisionOfYourLife = null;

            string adventureName = "The mines of Doom";
            
            Random rng = new Random();

            Console.Write("Enter your name: ");
            string playerName = Console.ReadLine();

            Console.Write("Enter your currentHealth: ");
            int playerHealth = int.Parse(Console.ReadLine());

            Console.WriteLine($"Welcome to the {adventureName} {playerName}, you health is {playerHealth} ");

            Console.WriteLine("Do you want to go or leave?");
            decisionOfYourLife = Console.ReadLine();

            if (decisionOfYourLife == "go")
            { // 1st Random Encounter (Skeleton King)
                d20 = rng.Next(20, 41);
                dMultiplier = rng.NextDouble();

                outcome = (int)(dMultiplier * d20);

                //Console.WriteLine(format: "D20 is {0} D20 Multiplier is {1}.", arg0: d20, arg1: dMultiplier);
                //Console.WriteLine((int)(dMultiplier * d20));

                Console.WriteLine("You ran into the dangerous Skeleton King!!!");

                Console.WriteLine($"You suffered {outcome} damage");

                playerHealth = playerHealth - outcome;
                numberOfEncounters += 1;

                //Output all of variable that were input by the player
                Console.WriteLine("-------Current Player stats-------");
                Console.WriteLine("Player name: " + playerName); //output name
                Console.WriteLine("Player current health: " + playerHealth); //output age
                Console.WriteLine("Player faced encounters: " + numberOfEncounters);
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("What a wuss!");
                return;
            }

            Console.WriteLine("Do you want to go or leave?");
            decisionOfYourLife = Console.ReadLine();

            // 2nd Random Encounter (Potion)
            if (decisionOfYourLife == "go")
            {
                d20 = rng.Next(1, 10);
                dMultiplier = rng.NextDouble();

                outcome = (int)(dMultiplier * d20);

                Console.WriteLine("You found a health potion!!!");

                Console.WriteLine($"You healed for {outcome} damage");

                playerHealth = playerHealth + outcome;
                numberOfEncounters += 1;

                //Output all of variable that were input by the player
                Console.WriteLine("-------Current Player stats-------");
                Console.WriteLine("Player name: " + playerName); //output name
                Console.WriteLine("Player current health: " + playerHealth); //output age
                Console.WriteLine("Player faced encounters: " + numberOfEncounters);
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("What a wuss!");
                return;
            }

            Console.WriteLine("Do you want to go or leave?");
            decisionOfYourLife = Console.ReadLine();

            // 3rd Random Encounter (Zombie Minotaur)
            if (decisionOfYourLife == "go")
            {
                d20 = rng.Next(20, 41);
                dMultiplier = rng.NextDouble();

                outcome = (int)(dMultiplier * d20);

                Console.WriteLine("You ran into the mighty Zombie Minotaur!!!");

                Console.WriteLine($"You suffered {outcome} damage");

                playerHealth = playerHealth - outcome;
                numberOfEncounters += 1;

                //Output all of variable that were input by the player
                Console.WriteLine("-------Current Player stats-------");
                Console.WriteLine("Player name: " + playerName); //output name
                Console.WriteLine("Player health: " + playerHealth); //output health
                Console.WriteLine("Player faced encounters: " + numberOfEncounters);
            }
            else
            {
                Console.WriteLine("What a wuss!");
                return;
            }

            // Final outcome of our hero ! 
            if (playerHealth > 0)
            {
                Console.WriteLine($"Congrats!! You survived {adventureName} {playerName}!! You earn 1000 rubies! And a sword! And a good shield.. ");
            }
            else
            {
                Console.WriteLine($"I am so sorry!! You have died within {adventureName} {playerName}.. :/ No rubies for you, just a shallow grave my friend..");
            }

            
        }

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


        static void makeAMove(char[,] myMap)
        {
            Console.WriteLine("Use arrow keys (Esc to quit):");

            while (true)
            {
                var key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.Clear();
                        playerPosY -= 1;
                        if (playerPosY < 0)
                        {
                            Console.WriteLine("You cannot go there!");
                            playerPosY += 1;
                            myMap = updateMyMap(myMap);
                            drawMyMap(myMap);
                            drawMyStats();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You go North");
                            myMap = updateMyMap(myMap);
                            drawMyMap(myMap);
                            drawMyStats();
                            break;
                        }
                        

                    case ConsoleKey.DownArrow:
                        Console.Clear();
                        Console.WriteLine("You go South");
                        playerPosY += 1;
                        myMap = updateMyMap(myMap);
                        drawMyMap(myMap);
                        drawMyStats();
                        break;

                    case ConsoleKey.LeftArrow:
                        Console.Clear();
                        Console.WriteLine("You go West");
                        playerPosX -= 1;
                        myMap = updateMyMap(myMap);
                        drawMyMap(myMap);
                        drawMyStats();
                        break;

                    case ConsoleKey.RightArrow:
                        Console.Clear();
                        Console.WriteLine("You go East");
                        playerPosX += 1;
                        myMap = updateMyMap(myMap);
                        drawMyMap(myMap);
                        drawMyStats();
                        break;

                    case ConsoleKey.Escape:
                        return;
                }
            }
        }

        static char[,] createAMap(int size)
        {
            int rows = size;
            int cols = size;

            char[,] myMap = new char[rows, cols];

            // fill with spaces
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    myMap[i, j] = '#';
                }
            }

            //Console.WriteLine(myMap);

            return myMap;
        }

        static void drawMyMap(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    if (j == playerPosX && i == playerPosY)
                    {
                        Console.Write($"[{'X'}]");
                    }
                    else
                    {
                       Console.Write($"[{matrix[i, j]}]");
                    }

                        
                }
                Console.WriteLine();
            }
        }

        static void drawMyStats()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("Player stats:");
            Console.WriteLine($"{dungeonName} Lvl. {dungeonLevel}");
            Console.WriteLine("Player Health: " + playerHealth); 
            Console.WriteLine("Player name: " + playerName); 
            Console.WriteLine("Player Exp: " + playerExp); 
            
            Console.WriteLine("=======================================");
        }
    
        static char[,] updateMyMap(char[,] myMatrix)
        {
            myMatrix[playerPosY, playerPosX] = ' ';

            return myMatrix;
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