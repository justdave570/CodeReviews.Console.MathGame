using MathGame.Models;

namespace MathGame
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>
    {
        //new Game { Date = DateTime.Now.AddDays(-1), Difficulty = DifficultyLevel.Easy, Type = GameType.Addition, Score = 5 },
        //new Game { Date = DateTime.Now.AddDays(2), Difficulty = DifficultyLevel.Medium, Type = GameType.Multiplication, Score = 4 },
        //new Game { Date = DateTime.Now.AddDays(3), Difficulty = DifficultyLevel.Hard, Type = GameType.Division, Score = 4 },
        //new Game { Date = DateTime.Now.AddDays(-4), Difficulty = DifficultyLevel.Expert, Type = GameType.Subtraction, Score = 3 },
        //new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
        //new Game { Date = DateTime.Now.AddDays(-6), Type = GameType.Multiplication, Score = 2 },
        //new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
        //new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
        //new Game { Date = DateTime.Now.AddDays(-9), Type = GameType.Addition, Score = 4 },
        //new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
        //new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
        //new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
        //new Game { Date = DateTime.Now.AddDays(-13), Type = GameType.Subtraction, Score = 5 },
    };
        internal static void PrintGames()
        {
            // var gamesToPrint = games.Where(x => x.Score < inputValue)

            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("---------------------------------------------------------------------------");

            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - Difficulty: {game.Difficulty} - {game.Type}: Score {game.Score}pts");
            }

            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("\nPress any key to return to main menu. . .");
            Console.ReadKey();
        }
        internal static void AddToHistory(int gameScore, Models.GameType gameType, int difficulty)
        {
            
            games.Add(new Game
            {
                Date = DateTime.Now,
                Difficulty = SetDifficulty(difficulty),
                Score = gameScore,
                Type = gameType
            });
        }
        internal static int[] GetNumbers(int difficulty)
        {
            var random = new Random();
            var firstNumber = random.Next(1, difficulty);
            var secondNumber = random.Next(1, difficulty);

            var result = new int[2];
            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }
        internal static int[] GetDivisionNumbers(int difficulty)
        {
            var random = new Random();
            var firstNumber = random.Next(1, difficulty);
            var secondNumber = random.Next(1, difficulty);

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, difficulty);
                secondNumber = random.Next(1, difficulty);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }
        internal static string GetName()
        {
            Console.WriteLine("Please enter your name: ");

            var userName = Console.ReadLine();

            while(string.IsNullOrEmpty(userName))
            {
                Console.WriteLine("Name cannot be empty. Please enter a valid name. . .");
                userName = Console.ReadLine();
            }

            return UppercaseFirstLetter(userName);
        }
        internal static int ValidateResult(string result)
        {
            int resultNumber = 0;
            while (string.IsNullOrEmpty(result) || !int.TryParse(result, out resultNumber))
            {
                Console.WriteLine("Invalid input. Please enter an integer. . .");
                result = Console.ReadLine();
            }
            return resultNumber;
        }
        internal static void GetFinalScore(int score)
        {
            Console.WriteLine($"Game over! Your final score is {score}pts!\nPress any key to continue. . .");
            Console.ReadKey();
        }
        internal static int GetDifficulty()
        {
            Console.Clear();
            string difficultyMenu = @"--------------------------------------------------------------------------
What difficulty would you like to attempt? (Choose from the options below)
--------------------------------------------------------------------------
                            1. - Easy (Numbers 0 - 10)
                            2. - Medium (Numbers 0 - 25)
                            3. - Hard (Numbers 0 - 50)
                            4. - Expert (Numbers 0 - 100)
--------------------------------------------------------------------------";
            int difficulty = 10;

            Console.WriteLine(difficultyMenu);
            int menuChoice = ValidateResult(Console.ReadLine());

            switch (menuChoice)
            {
                case 1:
                    difficulty = 10;
                    break;
                case 2:
                    difficulty = 25;
                    break;
                case 3:
                    difficulty = 50;
                    break;
                case 4:
                    difficulty = 100;
                    break;
                default:
                    Console.WriteLine("Invalid Input. Press any key to continue. . .");
                    Console.ReadKey();
                    break;
            }

            return difficulty;
        }
        internal static Models.DifficultyLevel SetDifficulty(int difficulty)
        {
            Models.DifficultyLevel diff;

            if (difficulty == 25)
            {
                diff = Models.DifficultyLevel.Medium;
            }
            else if (difficulty == 50)
            {
                diff = Models.DifficultyLevel.Hard;
            }
            else if (difficulty == 100)
            {
                diff = Models.DifficultyLevel.Expert;
            }
            else
            {
                diff = Models.DifficultyLevel.Easy;
            }

            return diff;
        }
        internal static string UppercaseFirstLetter(string input)
        {
            return char.ToUpper(input[0]) + input.Substring(1);
        }
    }
}
