using System;

namespace Question1
{
    class Program
    {

        static int Pow(int num, int pow)
        {
            if (pow == 0)
            {
                return 1;
            }

            int number = num * Pow(num, pow - 1);

            return number;
        }

        static int numberChecker()
        {
            int numberAndPow;

            for (; ; )
            {
                string numberJust = Console.ReadLine();

                if (Int32.TryParse(numberJust, out numberAndPow))
                {
                    return numberAndPow;
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
            bool selectionForSwitch = false;
            do
            {
                Console.Write("Enter number: ");
                int number = numberChecker();
                Console.Write("Enter power: ");
                int pow = numberChecker();
                Console.WriteLine($"Result: {Pow(number, pow)}");

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
                } while (selectionForSwitch == false);
            }
            while (selection == true);
            Console.ReadKey();

        }
    }
}
