using System;

namespace My_First_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.UtcNow;
            bool isGameOn = true;

            string name = GetName();

            Menu(name);

            string gameSelected = Console.ReadLine();

            do
            {
                switch (gameSelected?.ToLower().Trim())
                {
                    case "a":
                        AdditionGame("Addition Game");
                        break;

                    case "s":
                        SubtractionGame("Subtraction Game");
                        break;

                    case "m":
                        MultiplicationGame("Multiplication Game");
                        break;
                    case "d":
                        DivisionGame("Division Game");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }

            } while (isGameOn);


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

                    if (i > 0)
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
                        Console.WriteLine($"Game Over. Your Final score is {score}");
                }
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

            int[] GetDivisionNumbers()
            {
                var random = new Random();
                int firstNumber = random.Next(1, 100);
                int secondNumber = random.Next(1, 100);

                while (firstNumber % secondNumber != 0)
                {
                    firstNumber = random.Next(0, 99);
                    secondNumber = random.Next(0, 99);
                }
                int[] result = [firstNumber, secondNumber];
                return result;
            }
        }


    }
}
