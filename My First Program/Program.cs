using System;

namespace My_First_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.UtcNow;

            string name = GetName();

            Menu(name);

            string gameSelected = Console.ReadLine();

            switch (gameSelected?.ToLower().Trim())
            {
                case "a":
                    AdditionGame();
                    break;

                case "s":
                    SubtractionGame();
                    break;

                case "m":
                    MultiplicationGame();
                    break;
                case "d":
                    DivisionGame();
                    break;
                case "q":
                    Console.WriteLine("Goodbye");
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

            Console.ReadLine();

            void Menu(string name)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"Hello {name}. Its {date}. This is your math game. That's great that you're working on improving yourself\n");
                Console.WriteLine($@"what game would you like to play today? Choose from the options below: 
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

            void AdditionGame()
            {
                var random = new Random();
                int firstNumber;
                int secondNumber;
                var score = 0;

                for (int i = 0; i < 5; i++)
                {
                    firstNumber = random.Next(1, 10);
                    secondNumber = random.Next(1, 10);

                    Console.WriteLine($"What is the sum of {firstNumber} + {secondNumber} ?");
                    var result = Console.ReadLine();

                    if (!string.IsNullOrEmpty(result))
                    {
                        if (int.Parse(result) == firstNumber + secondNumber)
                        {
                            Console.WriteLine("You answer is correct!");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine($@"Your answer was incorrect!
    The correct answer is {firstNumber + secondNumber}.
    you have {4 - i} tries left.
                            ");                
                        }
                    }

                    if (i == 4)
                        Console.WriteLine($"Game Over. Your Final score is {score}");
                }
            }

            void SubtractionGame()
            {
                var random = new Random();
                int firstNumber;
                int secondNumber;
                var score = 0;

                for (int i = 0; i < 5; i++)
                {
                    firstNumber = random.Next(1, 10);
                    secondNumber = random.Next(1, 10);

                    Console.WriteLine($"What is the result for the subtraction of {firstNumber} - {secondNumber} ?");
                    var result = Console.ReadLine();

                    if (!string.IsNullOrEmpty(result))
                    {
                        if (int.Parse(result) == firstNumber - secondNumber)
                        {
                            Console.WriteLine("You answer is correct!");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine($@"Your answer was incorrect!
    The correct answer is {firstNumber - secondNumber}.
    you have {4 - i} tries left.
                            ");
                        }
                    }

                    if (i == 4)
                        Console.WriteLine($"Game Over. Your Final score is {score}");
                }
            }

            void DivisionGame()
            {
                Console.WriteLine("division game selected!");
            }

            void MultiplicationGame()
            {
                var random = new Random();
                int firstNumber;
                int secondNumber;
                var score = 0;

                for (int i = 0; i < 5; i++)
                {
                    firstNumber = random.Next(1, 10);
                    secondNumber = random.Next(1, 10);

                    Console.WriteLine($"What is the multiplication of {firstNumber} * {secondNumber} ?");
                    var result = Console.ReadLine();

                    if (!string.IsNullOrEmpty(result))
                    {
                        if (int.Parse(result) == firstNumber * secondNumber)
                        {
                            Console.WriteLine("You answer is correct!");
                            score++;
                        }
                        else
                        {
                            Console.WriteLine($@"Your answer was incorrect!
    The correct answer is {firstNumber * secondNumber}.
    you have {4 - i} tries left.
                            ");
                        }
                    }

                    if (i == 4)
                        Console.WriteLine($"Game Over. Your Final score is {score}");
                }
            }


        }


    }
}
