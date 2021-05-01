using System;

namespace Question6
{
    class Program
    {

        public static int[] a = new int[4];
        public static int[] q = new int[4];

        public static void MyRandom()
        {
            Random rand = new Random();
            for (int i = 0; i < 4; ++i)
            {
                q[i] = rand.Next(0,9) % 10;
            }
        }

        public static void Display(int n)
        {
            ++n;
            int num;

            Console.Write("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());


            if (Checker(num))
            {
                Console.Write($"Congratulation, {num} it's a lucky number, number attempts = {n}");

            }
            else
            {
                Display(n);
            }
        }

        static void CowAndBull()
        {
            MyRandom();

            Display(0);
        }

        public static bool Checker(int num)
        {
            for (int i = 3; i >= 0; --i)
            {
                a[i] = num % 10;
                num /= 10;
            }

            int bulls = 0;
            int cows = 0;
            bool[] c_check = new bool[4];

            for (int i = 0; i < 4; ++i)
            {
                if (q[i] == a[i])
                {
                    ++bulls;
                    c_check[i] = true;
                }
            }

            for (int i = 0; i < 4; ++i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    if (i == j || c_check[j])
                    {
                        continue;
                    }
                    if (a[i] == q[j])
                    {
                        ++cows;
                        c_check[j] = true;
                        break;
                    }
                }
            }

            if (bulls == 4) return true;

            Console.WriteLine($"Bulls = {bulls} time.\nCows = {cows} time. ");

            return false;
        }

        static void Main(string[] args)
        {
            bool selection = true;
            bool selectionForSwitch = false;

            do
            {
                CowAndBull();

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
            } while (selection == true) ;
            Console.ReadKey();
        }
    }
}