namespace MathGame
{
    internal class Menu
    {
        GameEngine game = new GameEngine();
        internal void MainMenu(string userName, DateTime date)
        {
            Console.Clear();
            int difficulty = Helpers.GetDifficulty();

            Console.Clear();
            string greeting = $@"-----------------------------------------------------------
Hello {userName}. Today is {date.DayOfWeek}. 
Welcome to the math game! 
You have chosen {Helpers.SetDifficulty(difficulty).ToString()} difficulty.
-----------------------------------------------------------
Press any key to continue. . .";

            Console.WriteLine(greeting);
            Console.ReadKey();

            bool isGameOn = true;

            do
            {
                Console.Clear();
                string mainMenu = $@"-------------------------------------------------------------------------
 What game would you like to play today? (Choose from the options below):
 Difficulty: {Helpers.SetDifficulty(difficulty).ToString()}
-------------------------------------------------------------------------
                            1. - Addition 
                            2. - Subtraction
                            3. - Multiplication
                            4. - Division
                            5. - Random
                            6. - View Previous Games
                            7. - Change Difficulty
                            0. - Exit Game
-------------------------------------------------------------------------";
                Console.WriteLine(mainMenu);
                var menuInput = Console.ReadLine();
                int menuChoice = Helpers.ValidateResult(menuInput);

                switch (menuChoice)
                {
                    case 1:
                        game.MathGame(Models.GameType.Addition, "Addition Game", difficulty);
                        break;
                    case 2:
                        game.MathGame(Models.GameType.Subtraction, "Subtraction Game", difficulty);
                        break;
                    case 3:
                        game.MathGame(Models.GameType.Multiplication, "Multiplication Game", difficulty);
                        break;
                    case 4:
                        game.MathGame(Models.GameType.Division, "Division Game", difficulty);
                        break;
                    case 5:
                        game.MathGame(Models.GameType.Random, "Random Game", difficulty);
                        break;
                    case 6:
                        Helpers.PrintGames();
                        break;
                    case 7:
                        difficulty = Helpers.GetDifficulty();
                        break;
                    case 0:
                        Console.WriteLine($"Thanks for playing {userName}");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Press any key to continue. . .");
                        Console.ReadKey();
                        break;
                }
            } while (isGameOn);
        }
    }
}
