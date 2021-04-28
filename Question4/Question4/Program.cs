using System;

namespace Question4
{
    class Program
    {
        static int DiapozonSumm(int firstNumber, int secondNumber)
        {
            if (firstNumber == secondNumber)
            {
                return 0;
            }

            else if (firstNumber > secondNumber)
            {
                return 0;
            }

            else
            {
                return secondNumber + DiapozonSumm(firstNumber, secondNumber - 1);
            }
        }

        static int NumberChecker()
        {
            int number;

            for (; ; )
            {
                string numberJust = Console.ReadLine();

                if (Int32.TryParse(numberJust, out number))
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
            bool salamos1 = true;
            bool selection = true;
            bool selectionForSwitch = false;
            do
            {
                int summ;
                int firstNumber;
                int seconNumber;

                Console.Write("Enter from number: ");
                firstNumber = NumberChecker();

                do
                {
                    Console.Write("Enter till number: ");
                    seconNumber = NumberChecker();

                    if (firstNumber > seconNumber)
                    {
                        Console.WriteLine("\nFirst number can not be bigger than second\nPlese enter correct diapozon\n");
                        salamos1 = false;
                    }

                    else
                    {
                        salamos1 = true;
                    }

                    summ = DiapozonSumm(firstNumber, seconNumber);

                }
                while (salamos1 == false);

                Console.WriteLine($"Diapozon summ = {summ - seconNumber}");
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
