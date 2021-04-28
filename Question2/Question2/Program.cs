using System;

namespace Question2
{
    class Program
    {
        static int Recursion(int firstNumber, int secondNumber)
        {
            if (firstNumber == secondNumber)
            {
                return firstNumber;
            }

            else if (firstNumber > secondNumber)
            {
                return Recursion(firstNumber - secondNumber, secondNumber);
            }

            else if (firstNumber < 0)
            {
                return firstNumber * -1;
            }

            else if (secondNumber < 0)
            {
                return secondNumber * -1;
            }

            else
            {
                return Recursion(firstNumber, secondNumber - firstNumber);
            }
        }

        static int NumberChecker()
        {
            int number;

            for (; ; )
            {
                string numberInString = Console.ReadLine();

                if (Int32.TryParse(numberInString, out number))
                {
                    return number;
                }
                else
                {
                    Console.Write("Incorrect number, please enter again: ");
                }
            }
        }

        static void Main(string[] args)
        {

            bool selection = true;
            bool checkerRecursion = true;
            bool selectionForSwitch = false;

            do
            {
                int result;
                int firstNumber;
                int seconNumber;

                do
                {
                    Console.Write("Enter first number: ");
                    firstNumber = NumberChecker();
                    if (firstNumber == 0)
                    {
                        Console.WriteLine("Incorrect please enter number from 1\n");
                        checkerRecursion = false;
                    }
                    else
                    {
                        checkerRecursion = true;
                    }
                }
                while (checkerRecursion == false);

                do
                {
                    Console.Write("Enter second number: ");
                    seconNumber = NumberChecker();
                    if (seconNumber == 0)
                    {
                        Console.WriteLine("Incorrect please enter number from 1\n");
                        checkerRecursion = false;
                    }
                    else
                    {
                        checkerRecursion = true;
                    }
                }
                while (checkerRecursion == false);

                result = Recursion(firstNumber, seconNumber);
                Console.WriteLine($"NOD = {result}");

                Console.Write("\nWould you try again ? (Y/y) or (N/n): ");
                do
                {
                    string symbolForSwitch = Convert.ToString(Console.ReadLine());
                    switch (symbolForSwitch)
                    {
                        case "Y":
                            {
                                selection = true;
                                selectionForSwitch = true;
                                break;
                            }
                        case "y":
                            {
                                selection = true;
                                selectionForSwitch = true;
                                break;
                            }
                        case "N":
                            {
                                Console.WriteLine("Have a good day :)");
                                selection = false;
                                selectionForSwitch = true;
                                break;
                            }
                        case "n":
                            {
                                Console.WriteLine("Have a good day :)");
                                selection = false;
                                selectionForSwitch = true;
                                break;
                            }
                        default:
                            {
                                Console.Write("You enter incorrect symbol, please enter Y/y or N/n: ");
                                selectionForSwitch = false;
                                selection = true;
                                continue;
                            }
                    }
                }
                while (selectionForSwitch == false);
            }
            while (selection == true);
            Console.ReadKey();
        }
    }
}
