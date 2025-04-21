using System;
using static System.Formats.Asn1.AsnWriter;

namespace My_First_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.UtcNow;
            bool isGameOn = true;
            List<string> gameHistory = new List<string>();

            string name = GetName();

            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Hello {name}. Its {date}. This is your math game. That's great that you're working on improving yourself\n");
            Menu(name);


            string gameSelected = Console.ReadLine();

            do
            {
                switch (gameSelected.ToLower().Trim())
                {
                    case "v":
                        GetGameHistory();
                        break;

                    case "a":
                        AdditionGame("Addition Game");
                        break;

                    case "s":
                        Menu(name);
                        SubtractionGame("Subtraction Game");
                        break;


                    case "m":
                        Menu(name);
                        MultiplicationGame("Multiplication Game");
                        break;

                    case "d":
                        Menu(name);
                        DivisionGame("Division Game");
                        break;

                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;

                    default:
                        Console.WriteLine("\nInvalid selection");
                        Menu(name);
                        gameSelected = Console.ReadLine();
                        break;
                }

            } while (isGameOn);


            Console.ReadLine();

            void Menu(string name)
            {
                Console.WriteLine($@"what game would you like to play today? Choose from the options below: 
                                    V - View your game history
                                    A - Addition
                                    S - Subtraction
                                    M - Multiplication
                                    D - Division
                                    Q - Quit the program
");
                Console.WriteLine("--------------------------------------------");
            }

            string GetName()
            {
                Console.WriteLine("please type your name");

                string name = Console.ReadLine();
                return name;
            }

            void AdditionGame(string message)
            {
                var random = new Random();
                int firstNumber;
                int secondNumber;
                var score = 0;

                for (int i = 0; i < 5; i++)
                {
                    Console.Clear();
                    Console.WriteLine(message);

                    firstNumber = random.Next(1, 10);
                    secondNumber = random.Next(1, 10);

                    Console.WriteLine($"What is the sum of {firstNumber} + {secondNumber} ?");
                    var result = Console.ReadLine();

                    if (!string.IsNullOrEmpty(result))
                    {
                        if (int.Parse(result) == firstNumber + secondNumber)
                        {
                            Console.WriteLine("You answer is correct! \n  Type any key for the next question");
                            score++;
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine($@"Your answer was incorrect!
    The correct answer is {firstNumber + secondNumber}.
    you have {4 - i} tries left.
    Type any key for the next question
                            ");
                            Console.ReadLine();
                        }
                    }

                    if (i == 4)
                    {
                        Console.WriteLine($"Game Over. Your Final score is {score}");
                        Console.WriteLine("Press any key to go back to the main menu");
                        Console.ReadLine();
                        Console.Clear();
                        Menu(name);
                        gameSelected = Console.ReadLine();
                    };
                }

                AddToHistory(score, "Addition");
            }

            void SubtractionGame(string message)
            {
                var random = new Random();
                int firstNumber;
                int secondNumber;
                var score = 0;

                for (int i = 0; i < 5; i++)
                {
                    Console.Clear();
                    Console.WriteLine(message);

                    firstNumber = random.Next(1, 10);
                    secondNumber = random.Next(1, 10);

                    Console.WriteLine($"What is the result for the subtraction of {firstNumber} - {secondNumber} ?");
                    var result = Console.ReadLine();

                    if (!string.IsNullOrEmpty(result))
                    {
                        if (int.Parse(result) == firstNumber - secondNumber)
                        {
                            Console.WriteLine("You answer is correct! Type any key for the next question");
                            Console.ReadLine();
                            score++;
                        }
                        else
                        {
                            Console.WriteLine($@"Your answer was incorrect!
    The correct answer is {firstNumber - secondNumber}.
    you have {4 - i} tries left.Type any key for the next question
                            ");
                            Console.ReadLine();
                        }
                    }

                    if (i == 4)
                    {
                        Console.WriteLine($"Game Over. Your Final score is {score}");
                        Console.WriteLine("Press any key to go back to the main menu");
                        Console.ReadLine();
                        Console.Clear();
                        Menu(name);
                        gameSelected = Console.ReadLine();
                    };
                }

                AddToHistory(score, "Subtraction");
            }

            void DivisionGame(string message)
            {
                var divisionNumber = GetDivisionNumbers();
                var firstNumber = divisionNumber[0];
                var secondNumber = divisionNumber[1];
                var score = 0;

                for (int i = 0; i < 5; i++)
                {
                    Console.Clear();
                    Console.WriteLine(message);

                    if (i > 0 && i < 5)
                    {
                        divisionNumber = GetDivisionNumbers();
                        firstNumber = divisionNumber[0];
                        secondNumber = divisionNumber[1];
                    }

                    Console.WriteLine($"What is the result for the division of {firstNumber} / {secondNumber} ?");
                    var result = Console.ReadLine();

                    if (!string.IsNullOrEmpty(result))
                    {
                        if (int.Parse(result) == firstNumber / secondNumber)
                        {
                            Console.WriteLine("You answer is correct. Type any key for the next question");
                            score++;
                            Console.ReadLine();

                        }
                        else
                        {
                            Console.WriteLine($@"Your answer was incorrect!
    The correct answer is {firstNumber / secondNumber}.
    you have {4 - i} tries left. Type any key for the next question
                            ");
                            Console.ReadLine();
                        }
                    }

                    if (i == 4)
                    {
                        Console.WriteLine($"Game Over. Your Final score is {score}");
                        Console.WriteLine("Press any key to go back to the main menu");
                        Console.ReadLine();
                        Console.Clear();
                        Menu(name);
                        gameSelected = Console.ReadLine();
                    }
                }
                AddToHistory(score, "Division");

            }

            void MultiplicationGame(string message)
            {
                var random = new Random();
                int firstNumber;
                int secondNumber;
                var score = 0;

                for (int i = 0; i < 5; i++)
                {
                    Console.Clear();
                    Console.WriteLine(message);

                    firstNumber = random.Next(1, 10);
                    secondNumber = random.Next(1, 10);

                    Console.WriteLine($"What is the multiplication of {firstNumber} * {secondNumber} ?");
                    var result = Console.ReadLine();

                    if (!string.IsNullOrEmpty(result))
                    {
                        if (int.Parse(result) == firstNumber * secondNumber)
                        {
                            Console.WriteLine("You answer is correct! Type any key for the next question");
                            score++;
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine($@"Your answer was incorrect!
    The correct answer is {firstNumber * secondNumber}.
    you have {4 - i} tries left. Type any key for the next question
                            ");
                            Console.ReadLine();
                        }
                    }

                    if (i == 4)
                    {
                        Console.WriteLine($"Game Over. Your Final score is {score}");
                        Console.WriteLine("Press any key to go back to the main menu");
                        Console.ReadLine();
                        Console.Clear();
                        Menu(name);
                        gameSelected = Console.ReadLine();
                    }
                }

                AddToHistory(score, "Multiplication");
            }

            void GetGameHistory()
            {
                Console.Clear();
                Console.WriteLine("Game History");
                Console.WriteLine("--------------------------------------------");

                foreach (var game in gameHistory)
                {
                    Console.WriteLine(game);
                }

                Console.WriteLine("--------------------------------------------\n");
                Console.WriteLine("Press any key to go back to the menu");
                Console.ReadLine();
            }

            void AddToHistory( int gameScore, string gameType)
            {
                gameHistory.Add($"{DateTime.Now} {gameType}: {gameScore} pts");
            }

            int[] GetDivisionNumbers()
            {
                var random = new Random();
                int firstNumber = random.Next(1, 100);
                int secondNumber = random.Next(1, 100);

                while (firstNumber % secondNumber != 0)
                {
                    firstNumber = random.Next(1, 100);
                    secondNumber = random.Next(1, 100);
                }
                int[] result = [firstNumber, secondNumber];
                return result;
            }
        }


    }
}
