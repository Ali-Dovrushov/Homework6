using System;

namespace Question5
{
    enum Days
    {
        Monday = 1,
        Thuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program
    {
        static int NumberChecker()
        {
            int number;

            for (; ; )
            {
                string numberInString = Console.ReadLine();

                if (Int32.TryParse(numberInString, out number) && number < 8 && number > 0)
                {
                    return number;
                }
                else
                {
                    Console.Write("Incorrect number, please enter number from 1 till 7: ");
                }
            }
        }

        static void Main(string[] args)
        {
            bool selection = true;
            bool selectionForSwitch = false;

            do
            {
                Console.Write("Enter number of week: ");
                Days weekDay = (Days)NumberChecker();

                Console.Write($"You are select: {weekDay}");
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
