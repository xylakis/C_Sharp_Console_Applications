namespace ConsoleApp1
{
    // The keyword internal prevents the class/code to be accessed directly 
    // by another program. 
    internal class Program
    {

        static public int mapSize = 10;

        static public int playerPosX = (int)mapSize/2;
        static public int playerPosY = (int)mapSize/2;

        static public int playerHealth = 100;
        static public string dungeonName = "The swamps";
        static public int dungeonLevel = 1;
        static public int playerExp = 0;
        static public string playerName = "Excelsior";

        static public float encounterPropability = 0.2f;
        


        static void Main(string[] args)
        {

            char[,] myMap = createAMap(mapSize);

            // 1st run of my Map
            myMap = updateMyMapCharMovement(myMap);
            drawMyMap(myMap);
            drawMyStats();


            // This runs in loop 
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
                        
                        //check if we are out of bounds Y NORTH 
                        if (playerPosY < 0)
                        {
                            Console.WriteLine("You cannot go there!");
                            playerPosY += 1;
                            myMap = updateMyMapCharMovement(myMap);
                            drawMyMap(myMap);
                            drawMyStats();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You go North");
                            checkForEncounter(encounterPropability);
                            myMap = updateMyMapCharMovement(myMap);
                            drawMyMap(myMap);
                            drawMyStats();
                            break;
                        }
                        
                    case ConsoleKey.DownArrow:
                        
                        Console.Clear();
                        playerPosY += 1;

                        if (playerPosY > mapSize-1)
                        {
                            Console.WriteLine("You cannot go there!");
                            playerPosY -= 1;
                            myMap = updateMyMapCharMovement(myMap);
                            drawMyMap(myMap);
                            drawMyStats();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You go South");
                            checkForEncounter(encounterPropability);
                            myMap = updateMyMapCharMovement(myMap);
                            drawMyMap(myMap);
                            drawMyStats();
                            break;
                        }


                    case ConsoleKey.LeftArrow:
                        Console.Clear();
                        playerPosX -= 1;

                        if (playerPosX < 0)
                        {
                            Console.WriteLine("You cannot go there!");
                            playerPosX += 1;
                            myMap = updateMyMapCharMovement(myMap);
                            drawMyMap(myMap);
                            drawMyStats();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You go West");
                            checkForEncounter(encounterPropability);
                            myMap = updateMyMapCharMovement(myMap);
                            drawMyMap(myMap);
                            drawMyStats();
                            break;
                        }

                    case ConsoleKey.RightArrow:
                        Console.Clear();
                        playerPosX += 1;

                        if (playerPosX > mapSize - 1)
                        {
                            Console.WriteLine("You cannot go there!");
                            playerPosX -= 1;
                            myMap = updateMyMapCharMovement(myMap);
                            drawMyMap(myMap);
                            drawMyStats();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You go East");
                            checkForEncounter(encounterPropability);
                            myMap = updateMyMapCharMovement(myMap);
                            drawMyMap(myMap);
                            drawMyStats();
                            break;
                        }
                        

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
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"[{'X'}]");
                        
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"[{matrix[i, j]}]");
                    }

                        
                }
                Console.WriteLine();
            }
        }

        static void drawMyStats()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=======================================");
            Console.WriteLine("Player stats:");
            Console.WriteLine($"{dungeonName} Lvl. {dungeonLevel}");
            Console.WriteLine("Player Health: " + playerHealth); 
            Console.WriteLine("Player name: " + playerName); 
            Console.WriteLine("Player Exp: " + playerExp); 
            
            Console.WriteLine("=======================================");
        }
    
        static char[,] updateMyMapCharMovement(char[,] myMatrix)
        {
            myMatrix[playerPosY, playerPosX] = ' ';

            return myMatrix;
        }
    
        static void checkForEncounter(float encounterPropability)
        {
            bool didEncounterOccur;
            
            Random rnd = new Random();

            double returnedValue = rnd.NextDouble();

            //didEncounterOccur = returnedValue < encounterPropability;

            if (returnedValue < encounterPropability)
            {
                enemyEncounter();
            }
            else if (returnedValue>=encounterPropability && encounterPropability<0.4) 
            {
                foundFood();
            }
            else if (returnedValue >= 0.4 && encounterPropability < 0.5) 
            {
                foundTreasure();
            }
            else
            {
                Console.WriteLine("No hostile Encounter you lucky bastard!");
            }

        }
    
        static void enemyEncounter()
        {

            Random rng = new Random();
            
            int d20 = rng.Next(20, 41);
            double dMultiplier = rng.NextDouble();

            int outcome = (int)(dMultiplier * d20);


            Console.WriteLine("You ran into the dangerous Skeleton King!!!");

            Console.WriteLine($"You suffered {outcome} damage");

            playerHealth = playerHealth - outcome;
            playerExp += 25;
        }
    
        static void foundFood()
        {
            Console.WriteLine("I found Food!!");
        }

        static void foundTreasure()
        {
            Console.WriteLine("I found Treasure !!!");
        }
    
    
    }
    
        
    
    }

