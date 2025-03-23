namespace MathGame
{
    internal class GameEngine
    {
        internal void MathGame(Models.GameType gameType, string message, int difficulty)
        {
            var random = new Random();
            int score = 0;

            int[] numbers;
            int firstNumber;
            int secondNumber;

            var result = "";
            int answer;

            switch (gameType)
            {
                case Models.GameType.Addition:

                    for (int i = 0; i < 5; i++)
                    {
                        Console.Clear();
                        Console.WriteLine(message);

                        numbers = Helpers.GetNumbers(difficulty);
                        firstNumber = numbers[0];
                        secondNumber = numbers[1];

                        Console.WriteLine($"{firstNumber} + {secondNumber}");
                        result = Console.ReadLine();
                        answer = Helpers.ValidateResult(result);

                        if (answer == firstNumber + secondNumber)
                        {
                            Console.WriteLine("That's correct! Press any key to continue. . .");
                            score++;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("That's incorrect. Press any key to continue. . .");
                            Console.ReadKey();
                        }
                    }
                    Helpers.AddToHistory(score, Models.GameType.Addition, difficulty);
                    break;

                case Models.GameType.Subtraction:

                    for (int i = 0; i < 5; i++)
                    {
                        Console.Clear();
                        Console.WriteLine(message);

                        numbers = Helpers.GetNumbers(difficulty);
                        firstNumber = numbers[0];
                        secondNumber = numbers[1];

                        Console.WriteLine($"{firstNumber} - {secondNumber}");
                        result = Console.ReadLine();
                        answer = Helpers.ValidateResult(result);

                        if (answer == firstNumber - secondNumber)
                        {
                            Console.WriteLine("That's correct! Press any key to continue. . .");
                            score++;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("That's incorrect. Press any key to continue. . .");
                            Console.ReadKey();
                        }
                    }
                    Helpers.AddToHistory(score, Models.GameType.Subtraction, difficulty);
                    break;

                case Models.GameType.Multiplication:

                    for (int i = 0; i < 5; i++)
                    {
                        Console.Clear();
                        Console.WriteLine(message);

                        numbers = Helpers.GetNumbers(difficulty);
                        firstNumber = numbers[0];
                        secondNumber = numbers[1];

                        Console.WriteLine($"{firstNumber} * {secondNumber}");
                        result = Console.ReadLine();
                        answer = Helpers.ValidateResult(result);

                        if (answer == firstNumber * secondNumber)
                        {
                            Console.WriteLine("That's correct! Press any key to continue. . .");
                            score++;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("That's incorrect. Press any key to continue. . .");
                            Console.ReadKey();
                        }
                    }
                    Helpers.AddToHistory(score, Models.GameType.Multiplication, difficulty);
                    break;

                case Models.GameType.Division:

                    for (int i = 0; i < 5; i++)
                    {
                        Console.Clear();
                        Console.WriteLine(message);

                        var divisionNumbers = Helpers.GetDivisionNumbers(difficulty);
                        firstNumber = divisionNumbers[0];
                        secondNumber = divisionNumbers[1];

                        Console.WriteLine($"{firstNumber} / {secondNumber}");
                        result = Console.ReadLine();
                        answer = Helpers.ValidateResult(result);

                        if (answer == firstNumber / secondNumber)
                        {
                            Console.WriteLine("That's correct! Press any key to continue. . .");
                            score++;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("That's incorrect. Press any key to continue. . .");
                            Console.ReadKey();
                        }
                    }
                    Helpers.AddToHistory(score, Models.GameType.Division, difficulty);
                    break;
                
                case Models.GameType.Random:
                    
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Clear();
                        Console.WriteLine(message);
                        int randomGameType = random.Next(0, 4);

                        switch (randomGameType)
                        {
                            case 0:
                                numbers = Helpers.GetNumbers(difficulty);
                                firstNumber = numbers[0];
                                secondNumber = numbers[1];

                                Console.WriteLine($"{firstNumber} + {secondNumber}");
                                result = Console.ReadLine();
                                answer = Helpers.ValidateResult(result);

                                if (answer == firstNumber * secondNumber)
                                {
                                    Console.WriteLine("That's correct! Press any key to continue. . .");
                                    score++;
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("That's incorrect. Press any key to continue. . .");
                                    Console.ReadKey();
                                }
                                break;

                            case 1:
                                numbers = Helpers.GetNumbers(difficulty);
                                firstNumber = numbers[0];
                                secondNumber = numbers[1];

                                Console.WriteLine($"{firstNumber} - {secondNumber}");
                                result = Console.ReadLine();
                                answer = Helpers.ValidateResult(result);

                                if (answer == firstNumber - secondNumber)
                                {
                                    Console.WriteLine("That's correct! Press any key to continue. . .");
                                    score++;
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("That's incorrect. Press any key to continue. . .");
                                    Console.ReadKey();
                                }
                                break;

                            case 2:
                                numbers = Helpers.GetNumbers(difficulty);
                                firstNumber = numbers[0];
                                secondNumber = numbers[1];

                                Console.WriteLine($"{firstNumber} * {secondNumber}");
                                result = Console.ReadLine();
                                answer = Helpers.ValidateResult(result);

                                if (answer == firstNumber * secondNumber)
                                {
                                    Console.WriteLine("That's correct! Press any key to continue. . .");
                                    score++;
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("That's incorrect. Press any key to continue. . .");
                                    Console.ReadKey();
                                }
                                break;

                            case 3:
                                numbers = Helpers.GetDivisionNumbers(difficulty);
                                firstNumber = numbers[0];
                                secondNumber = numbers[1];

                                Console.WriteLine($"{firstNumber} / {secondNumber}");
                                result = Console.ReadLine();
                                answer = Helpers.ValidateResult(result);

                                if (answer == firstNumber / secondNumber)
                                {
                                    Console.WriteLine("That's correct! Press any key to continue. . .");
                                    score++;
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("That's incorrect. Press any key to continue. . .");
                                    Console.ReadKey();
                                }
                                break;

                            default:
                                Console.WriteLine("Invalid Game Type. Press any key to continue. . .");
                                Console.ReadKey();
                                break;
                        }

                        
                    }
                    Helpers.AddToHistory(score, Models.GameType.Random, difficulty);
                    break;

                default:

                    Console.WriteLine("Invalid Game Type. Press any key to continue. . .");
                    Console.ReadKey();
                    break;
            }
            Helpers.GetFinalScore(score);
        }

    }
}
