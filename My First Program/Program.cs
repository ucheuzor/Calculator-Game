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
                Console.WriteLine("Addition game selected!");
            }

            void SubtractionGame()
            {
                Console.WriteLine("Subtraction game selected!");
            }

            void DivisionGame()
            {
                Console.WriteLine("division game selected!");
            }

            void MultiplicationGame()
            {
                Console.WriteLine("Multiplication game selected!");
            }


        }


    }
}
