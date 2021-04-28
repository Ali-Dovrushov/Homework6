using System;

namespace Question1
{
    class Program
    {

        static int PowForSum(int num, int pow)
        {
            //Отчет начинается по  условию со 2 степени.
            if (pow == 2)
            {
                return num *= num;
            }

            else
            {
                return num * num + (num * PowForSum(num, --pow));
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
            bool selectionForSwitch = false;
            do
            {
                Console.Write("Enter number: ");
                int number = NumberChecker();
                Console.Write("Enter power: ");
                int pow = NumberChecker();
                Console.WriteLine($"Result summ pow: {PowForSum(number, pow)}");

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
